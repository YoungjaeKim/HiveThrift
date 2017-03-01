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
#if !SILVERLIGHT

    
#endif
    public partial class SetPartitionsStatsRequest : TBase
    {
        public List<ColumnStatistics> ColStats { get; set; }

        public SetPartitionsStatsRequest()
        {
        }

        public SetPartitionsStatsRequest(List<ColumnStatistics> colStats)
            : this()
        {
            this.ColStats = colStats;
        }

        public void Read(TProtocol iprot)
        {
            bool isset_colStats = false;
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
                                ColStats = new List<ColumnStatistics>();
                                TList _list126 = iprot.ReadListBegin();
                                for (int _i127 = 0; _i127 < _list126.Count; ++_i127)
                                {
                                    ColumnStatistics _elem128 = new ColumnStatistics();
                                    _elem128 = new ColumnStatistics();
                                    _elem128.Read(iprot);
                                    ColStats.Add(_elem128);
                                }
                                iprot.ReadListEnd();
                            }
                            isset_colStats = true;
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
            if (!isset_colStats)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("SetPartitionsStatsRequest");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "colStats";
            field.Type = TType.List;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            {
                oprot.WriteListBegin(new TList(TType.Struct, ColStats.Count));
                foreach (ColumnStatistics _iter129 in ColStats)
                {
                    _iter129.Write(oprot);
                }
                oprot.WriteListEnd();
            }
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("SetPartitionsStatsRequest(");
            sb.Append("ColStats: ");
            sb.Append(ColStats);
            sb.Append(")");
            return sb.ToString();
        }
    }
}