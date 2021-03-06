/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocol;

namespace Hive
{
    public partial class AddPartitionsResult : TBase
    {
        private List<Partition> _partitions;

        public List<Partition> Partitions
        {
            get
            {
                return _partitions;
            }
            set
            {
                __isset.partitions = true;
                this._partitions = value;
            }
        }

        public Isset __isset;

        public struct Isset
        {
            public bool partitions;
        }

        public AddPartitionsResult()
        {
        }

        public void Read(TProtocol iprot)
        {
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
                                Partitions = new List<Partition>();
                                TList _list173 = iprot.ReadListBegin();
                                for (int _i174 = 0; _i174 < _list173.Count; ++_i174)
                                {
                                    Partition _elem175 = new Partition();
                                    _elem175 = new Partition();
                                    _elem175.Read(iprot);
                                    Partitions.Add(_elem175);
                                }
                                iprot.ReadListEnd();
                            }
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
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("AddPartitionsResult");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (Partitions != null && __isset.partitions)
            {
                field.Name = "partitions";
                field.Type = TType.List;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                {
                    oprot.WriteListBegin(new TList(TType.Struct, Partitions.Count));
                    foreach (Partition _iter176 in Partitions)
                    {
                        _iter176.Write(oprot);
                    }
                    oprot.WriteListEnd();
                }
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("AddPartitionsResult(");
            sb.Append("Partitions: ");
            sb.Append(Partitions);
            sb.Append(")");
            return sb.ToString();
        }
    }
}