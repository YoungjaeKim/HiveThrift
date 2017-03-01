/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Transport;

namespace Hive2
{
#if !SILVERLIGHT

#endif

    public partial class TI32Column : TBase
    {
        public List<int> Values { get; set; }

        public byte[] Nulls { get; set; }

        public TI32Column()
        {
        }

        public TI32Column(List<int> values, byte[] nulls) : this()
        {
            this.Values = values;
            this.Nulls = nulls;
        }

        public void Read(TProtocol iprot)
        {
            bool isset_values = false;
            bool isset_nulls = false;
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.List)
                        {
                            {
                                Values = new List<int>();
                                TList _list39 = iprot.ReadListBegin();
                                for (int _i40 = 0; _i40 < _list39.Count; ++_i40)
                                {
                                    int _elem41 = 0;
                                    _elem41 = iprot.ReadI32();
                                    Values.Add(_elem41);
                                }
                                iprot.ReadListEnd();
                            }
                            isset_values = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 2:
                        if (field.Type == TType.String)
                        {
                            Nulls = iprot.ReadBinary();
                            isset_nulls = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
            if (!isset_values)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_nulls)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("TI32Column");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "values";
            field.Type = TType.List;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            {
                oprot.WriteListBegin(new TList(TType.I32, Values.Count));
                foreach (int _iter42 in Values)
                {
                    oprot.WriteI32(_iter42);
                }
                oprot.WriteListEnd();
            }
            oprot.WriteFieldEnd();
            field.Name = "nulls";
            field.Type = TType.String;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteBinary(Nulls);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("TI32Column(");
            sb.Append("Values: ");
            sb.Append(Values);
            sb.Append(",Nulls: ");
            sb.Append(Nulls);
            sb.Append(")");
            return sb.ToString();
        }
    }
}