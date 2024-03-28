using Opc.Ua;
using Opc.Ua.Server;
using opcua_verification.addDevice;
using opcua_verification.freeUA;
using opcua_verification.gibh_athena;
using opcua_verification.TestNode;
using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace opcua_verification
{
    class VerificationServer : StandardServer
    {         /// <summary>
              /// Admin user.
              /// </summary>
        public static string AdminUser { get; set; } = "sysadmin";

        /// <summary>
        /// Admin user password.
        /// </summary>
        public static string AdminPassword { get; set; } = "demo";
        /// <summary>
        /// Initializes the server before it starts up.
        /// </summary>
        /// <remarks>
        /// This method is called before any startup processing occurs. The sub-class may update the 
        /// configuration object or do any other application specific startup tasks.
        /// </remarks>
        protected override void OnServerStarting(ApplicationConfiguration configuration)
        {
            Console.WriteLine("The Server is starting.");

            base.OnServerStarting(configuration);

            // it is up to the application to decide how to validate user identity tokens.
            // this function creates validators for X509 identity tokens.
            CreateUserIdentityValidators(configuration);
        }

        /// <summary>
        /// Called after the server has been started.
        /// </summary>
        protected override void OnServerStarted(IServerInternal server)
        {
            base.OnServerStarted(server);

            // request notifications when the user identity is changed. all valid users are accepted by default.
            server.SessionManager.ImpersonateUser += new ImpersonateEventHandler(SessionManager_ImpersonateUser);
        }

        private void CreateUserIdentityValidators(ApplicationConfiguration configuration)
        {
            for (int ii = 0; ii < configuration.ServerConfiguration.UserTokenPolicies.Count; ii++)
            {
                UserTokenPolicy policy = configuration.ServerConfiguration.UserTokenPolicies[ii];

                // create a validator for a certificate token policy.
                if (policy.TokenType == UserTokenType.Certificate)
                {
                    // the name of the element in the configuration file.
                    XmlQualifiedName qname = new XmlQualifiedName(policy.PolicyId, Namespaces.opcVer);

                    // find the location of the trusted issuers.
                    CertificateTrustList trustedIssuers = configuration.ParseExtension<CertificateTrustList>(qname);

                    if (trustedIssuers == null)
                    {
                        Utils.Trace(
                            (int)Utils.TraceMasks.Error,
                            "Could not load CertificateTrustList for UserTokenPolicy {0}",
                            policy.PolicyId);

                        continue;
                    }

                    // trusts any certificate in the trusted people store.
                    m_certificateValidator = X509CertificateValidator.PeerTrust;
                }
            }
        }

        /// <summary>
        /// Called when a client tries to change its user identity.
        /// </summary>
        private void SessionManager_ImpersonateUser(Session session, ImpersonateEventArgs args)
        {

#if TODO
            // check for a WSS token.
            IssuedIdentityToken wssToken = args.NewIdentity as IssuedIdentityToken;

            if (wssToken != null)
            {
                SecurityToken kerberosToken = ParseAndVerifyKerberosToken(wssToken.DecryptedTokenData);
                args.Identity = new UserIdentity(kerberosToken);
                Utils.Trace("Kerberos Token Accepted: {0}", args.Identity.DisplayName);
                return;
            }
#endif
            // check for a user name token.
            UserNameIdentityToken userNameToken = args.NewIdentity as UserNameIdentityToken;

            if (userNameToken != null)
            {
                VerifyPassword(userNameToken.UserName, userNameToken.DecryptedPassword);
                args.Identity = new UserIdentity(userNameToken);
                Utils.Trace("UserName Token Accepted: {0}", args.Identity.DisplayName);
                return;
            }

            // check for x509 user token.
            X509IdentityToken x509Token = args.NewIdentity as X509IdentityToken;

            if (x509Token != null)
            {
                VerifyCertificate(x509Token.Certificate);
                args.Identity = new UserIdentity(x509Token);
                Utils.Trace("X509 Token Accepted: {0}", args.Identity.DisplayName);
                return;
            }
        }
        /// <summary>
        /// Validates the password for a username token.
        /// </summary>
        private void VerifyPassword(string userName, string password)
        {
            IntPtr handle = IntPtr.Zero;

            const int LOGON32_PROVIDER_DEFAULT = 0;
            // const int LOGON32_LOGON_INTERACTIVE = 2;
            const int LOGON32_LOGON_NETWORK = 3;
            // const int LOGON32_LOGON_BATCH = 4;
            // user with permission to configure server
            if (!(userName == AdminUser && password == AdminPassword))
            {
                throw ServiceResultException.Create(StatusCodes.BadUserAccessDenied, "Login failed for user: {0}", userName);
            }
            //if (!((userName == DefaultUser && password == DefaultPassword)))
            //{
                
            //}
                //bool result = NativeMethods.LogonUser(
                //userName,
                //String.Empty,
                //password,
                //LOGON32_LOGON_NETWORK,
                //LOGON32_PROVIDER_DEFAULT,
                //ref handle);

            //if (!result)
            //{
            //    throw ServiceResultException.Create(StatusCodes.BadUserAccessDenied, "Login failed for user: {0}", userName);
            //}

            NativeMethods.CloseHandle(handle);
        }

        /// <summary>
        /// Verifies that a certificate user token is trusted.
        /// </summary>
        private void VerifyCertificate(X509Certificate2 certificate)
        {
            try
            {
                m_certificateValidator.Validate(certificate);
            }
            catch (Exception e)
            {
                // construct translation object with default text.
                TranslationInfo info = new TranslationInfo(
                    "InvalidCertificate",
                    "en-US",
                    "'{0}' is not a trusted user certificate.",
                    certificate.Subject);

                // create an exception with a vendor defined sub-code.
                throw new ServiceResultException(new ServiceResult(
                    e,
                    StatusCodes.BadIdentityTokenRejected,
                    "InvalidCertificate",
                    Namespaces.opcVer,
                    new LocalizedText(info)));
            }
        }
        private static class NativeMethods
        {
            [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern bool LogonUser(
                string lpszUsername,
                string lpszDomain,
                string lpszPassword,
                int dwLogonType,
                int dwLogonProvider,
                ref IntPtr phToken);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
            public extern static bool CloseHandle(IntPtr handle);
        }

        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // create the custom node managers.
            nodeManagers.Add(new VerificationNodeManager(server, configuration));
            nodeManagers.Add(new AddNodeManager(server, configuration));
            //nodeManagers.Add(new FreeUaManager(server, configuration));
            nodeManagers.Add(new gibh_athenaManager(server, configuration));
            // create master node manager.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "SecLib";
            properties.ProductName = "SecLib InformationModel Server";
            properties.ProductUri = "http://opcfoundation.org/SecLib/InformationModelServer/v1.0";
            properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber = Utils.GetAssemblyBuildNumber();
            properties.BuildDate = Utils.GetAssemblyTimestamp();

            // TBD - All applications have software certificates that need to added to the properties.

            return properties;
        }

        #region Private Fields
        private object m_impersonationLock = new object();
        private X509CertificateValidator m_certificateValidator;
        #endregion
    }
}
