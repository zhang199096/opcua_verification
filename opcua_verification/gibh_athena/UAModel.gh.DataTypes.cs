/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace UAModel.gh
{
    #region Descartes Class
    #if (!OPCUA_EXCLUDE_Descartes)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.gh.Namespaces.gh)]
    public partial class Descartes : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public Descartes()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_x = (float)0;
            m_y = (float)0;
            m_z = (float)0;
            m_rx = (float)0;
            m_ry = (float)0;
            m_rz = (float)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "x", IsRequired = false, Order = 1)]
        public float x
        {
            get { return m_x;  }
            set { m_x = value; }
        }

        /// <remarks />
        [DataMember(Name = "y", IsRequired = false, Order = 2)]
        public float y
        {
            get { return m_y;  }
            set { m_y = value; }
        }

        /// <remarks />
        [DataMember(Name = "z", IsRequired = false, Order = 3)]
        public float z
        {
            get { return m_z;  }
            set { m_z = value; }
        }

        /// <remarks />
        [DataMember(Name = "rx", IsRequired = false, Order = 4)]
        public float rx
        {
            get { return m_rx;  }
            set { m_rx = value; }
        }

        /// <remarks />
        [DataMember(Name = "ry", IsRequired = false, Order = 5)]
        public float ry
        {
            get { return m_ry;  }
            set { m_ry = value; }
        }

        /// <remarks />
        [DataMember(Name = "rz", IsRequired = false, Order = 6)]
        public float rz
        {
            get { return m_rz;  }
            set { m_rz = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.Descartes; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.Descartes_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.Descartes_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.gh.Namespaces.gh);

            encoder.WriteFloat("x", x);
            encoder.WriteFloat("y", y);
            encoder.WriteFloat("z", z);
            encoder.WriteFloat("rx", rx);
            encoder.WriteFloat("ry", ry);
            encoder.WriteFloat("rz", rz);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.gh.Namespaces.gh);

            x = decoder.ReadFloat("x");
            y = decoder.ReadFloat("y");
            z = decoder.ReadFloat("z");
            rx = decoder.ReadFloat("rx");
            ry = decoder.ReadFloat("ry");
            rz = decoder.ReadFloat("rz");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Descartes value = encodeable as Descartes;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_x, value.m_x)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;
            if (!Utils.IsEqual(m_z, value.m_z)) return false;
            if (!Utils.IsEqual(m_rx, value.m_rx)) return false;
            if (!Utils.IsEqual(m_ry, value.m_ry)) return false;
            if (!Utils.IsEqual(m_rz, value.m_rz)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (Descartes)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            Descartes clone = (Descartes)base.MemberwiseClone();

            clone.m_x = (float)Utils.Clone(this.m_x);
            clone.m_y = (float)Utils.Clone(this.m_y);
            clone.m_z = (float)Utils.Clone(this.m_z);
            clone.m_rx = (float)Utils.Clone(this.m_rx);
            clone.m_ry = (float)Utils.Clone(this.m_ry);
            clone.m_rz = (float)Utils.Clone(this.m_rz);

            return clone;
        }
        #endregion

        #region Private Fields
        private float m_x;
        private float m_y;
        private float m_z;
        private float m_rx;
        private float m_ry;
        private float m_rz;
        #endregion
    }

    #region DescartesCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDescartes", Namespace = UAModel.gh.Namespaces.gh, ItemName = "Descartes")]
    #if !NET_STANDARD
    public partial class DescartesCollection : List<Descartes>, ICloneable
    #else
    public partial class DescartesCollection : List<Descartes>
    #endif
    {
        #region Constructors
        /// <remarks />
        public DescartesCollection() {}

        /// <remarks />
        public DescartesCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public DescartesCollection(IEnumerable<Descartes> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator DescartesCollection(Descartes[] values)
        {
            if (values != null)
            {
                return new DescartesCollection(values);
            }

            return new DescartesCollection();
        }

        /// <remarks />
        public static explicit operator Descartes[](DescartesCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (DescartesCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DescartesCollection clone = new DescartesCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Descartes)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DesType Class
    #if (!OPCUA_EXCLUDE_DesType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.gh.Namespaces.gh)]
    public partial class DesType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public DesType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_x = new DoubleCollection();
            m_y = new DoubleCollection();
            m_z = new DoubleCollection();
            m_a = new DoubleCollection();
            m_b = new DoubleCollection();
            m_c = new DoubleCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "X", IsRequired = false, Order = 1)]
        public DoubleCollection X
        {
            get
            {
                return m_x;
            }

            set
            {
                m_x = value;

                if (value == null)
                {
                    m_x = new DoubleCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Y", IsRequired = false, Order = 2)]
        public DoubleCollection Y
        {
            get
            {
                return m_y;
            }

            set
            {
                m_y = value;

                if (value == null)
                {
                    m_y = new DoubleCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Z", IsRequired = false, Order = 3)]
        public DoubleCollection Z
        {
            get
            {
                return m_z;
            }

            set
            {
                m_z = value;

                if (value == null)
                {
                    m_z = new DoubleCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "A", IsRequired = false, Order = 4)]
        public DoubleCollection A
        {
            get
            {
                return m_a;
            }

            set
            {
                m_a = value;

                if (value == null)
                {
                    m_a = new DoubleCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "B", IsRequired = false, Order = 5)]
        public DoubleCollection B
        {
            get
            {
                return m_b;
            }

            set
            {
                m_b = value;

                if (value == null)
                {
                    m_b = new DoubleCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "C", IsRequired = false, Order = 6)]
        public DoubleCollection C
        {
            get
            {
                return m_c;
            }

            set
            {
                m_c = value;

                if (value == null)
                {
                    m_c = new DoubleCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.DesType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.DesType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.DesType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => throw new NotSupportedException(); 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.gh.Namespaces.gh);

            encoder.WriteDoubleArray("X", X);
            encoder.WriteDoubleArray("Y", Y);
            encoder.WriteDoubleArray("Z", Z);
            encoder.WriteDoubleArray("A", A);
            encoder.WriteDoubleArray("B", B);
            encoder.WriteDoubleArray("C", C);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.gh.Namespaces.gh);

            X = decoder.ReadDoubleArray("X");
            Y = decoder.ReadDoubleArray("Y");
            Z = decoder.ReadDoubleArray("Z");
            A = decoder.ReadDoubleArray("A");
            B = decoder.ReadDoubleArray("B");
            C = decoder.ReadDoubleArray("C");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DesType value = encodeable as DesType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_x, value.m_x)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;
            if (!Utils.IsEqual(m_z, value.m_z)) return false;
            if (!Utils.IsEqual(m_a, value.m_a)) return false;
            if (!Utils.IsEqual(m_b, value.m_b)) return false;
            if (!Utils.IsEqual(m_c, value.m_c)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (DesType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DesType clone = (DesType)base.MemberwiseClone();

            clone.m_x = (DoubleCollection)Utils.Clone(this.m_x);
            clone.m_y = (DoubleCollection)Utils.Clone(this.m_y);
            clone.m_z = (DoubleCollection)Utils.Clone(this.m_z);
            clone.m_a = (DoubleCollection)Utils.Clone(this.m_a);
            clone.m_b = (DoubleCollection)Utils.Clone(this.m_b);
            clone.m_c = (DoubleCollection)Utils.Clone(this.m_c);

            return clone;
        }
        #endregion

        #region Private Fields
        private DoubleCollection m_x;
        private DoubleCollection m_y;
        private DoubleCollection m_z;
        private DoubleCollection m_a;
        private DoubleCollection m_b;
        private DoubleCollection m_c;
        #endregion
    }

    #region DesTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDesType", Namespace = UAModel.gh.Namespaces.gh, ItemName = "DesType")]
    #if !NET_STANDARD
    public partial class DesTypeCollection : List<DesType>, ICloneable
    #else
    public partial class DesTypeCollection : List<DesType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public DesTypeCollection() {}

        /// <remarks />
        public DesTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public DesTypeCollection(IEnumerable<DesType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator DesTypeCollection(DesType[] values)
        {
            if (values != null)
            {
                return new DesTypeCollection(values);
            }

            return new DesTypeCollection();
        }

        /// <remarks />
        public static explicit operator DesType[](DesTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (DesTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DesTypeCollection clone = new DesTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DesType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}