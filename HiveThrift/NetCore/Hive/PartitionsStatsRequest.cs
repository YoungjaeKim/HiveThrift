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
    public partial class PartitionsStatsRequest : TBase
    {
        public string DbName { get; set; }

        public string TblName { get; set; }

        public List<string> ColNames { get; set; }

        public List<string> PartNames { get; set; }

        public PartitionsStatsRequest()
        {
        }

        public PartitionsStatsRequest(string dbName, string tblName, List<string> colNames, List<string> partNames)
            : this()
        {
            this.DbName = dbName;
            this.TblName = tblName;
            this.ColNames = colNames;
            this.PartNames = partNames;
        }

        public void Read(TProtocol iprot)
        {
            bool isset_dbName = false;
            bool isset_tblName = false;
            bool isset_colNames = false;
            bool isset_partNames = false;
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
                        if (field.Type == TType.String)
                        {
                            DbName = iprot.ReadString();
                            isset_dbName = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 2:
                        if (field.Type == TType.String)
                        {
                            TblName = iprot.ReadString();
                            isset_tblName = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 3:
                        if (field.Type == TType.List)
                        {
                            {
                                ColNames = new List<string>();
                                TList _list165 = iprot.ReadListBegin();
                                for (int _i166 = 0; _i166 < _list165.Count; ++_i166)
                                {
                                    string _elem167 = null;
                                    _elem167 = iprot.ReadString();
                                    ColNames.Add(_elem167);
                                }
                                iprot.ReadListEnd();
                            }
                            isset_colNames = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 4:
                        if (field.Type == TType.List)
                        {
                            {
                                PartNames = new List<string>();
                                TList _list168 = iprot.ReadListBegin();
                                for (int _i169 = 0; _i169 < _list168.Count; ++_i169)
                                {
                                    string _elem170 = null;
                                    _elem170 = iprot.ReadString();
                                    PartNames.Add(_elem170);
                                }
                                iprot.ReadListEnd();
                            }
                            isset_partNames = true;
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
            if (!isset_dbName)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_tblName)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_colNames)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_partNames)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("PartitionsStatsRequest");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "dbName";
            field.Type = TType.String;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(DbName);
            oprot.WriteFieldEnd();
            field.Name = "tblName";
            field.Type = TType.String;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(TblName);
            oprot.WriteFieldEnd();
            field.Name = "colNames";
            field.Type = TType.List;
            field.ID = 3;
            oprot.WriteFieldBegin(field);
            {
                oprot.WriteListBegin(new TList(TType.String, ColNames.Count));
                foreach (string _iter171 in ColNames)
                {
                    oprot.WriteString(_iter171);
                }
                oprot.WriteListEnd();
            }
            oprot.WriteFieldEnd();
            field.Name = "partNames";
            field.Type = TType.List;
            field.ID = 4;
            oprot.WriteFieldBegin(field);
            {
                oprot.WriteListBegin(new TList(TType.String, PartNames.Count));
                foreach (string _iter172 in PartNames)
                {
                    oprot.WriteString(_iter172);
                }
                oprot.WriteListEnd();
            }
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("PartitionsStatsRequest(");
            sb.Append("DbName: ");
            sb.Append(DbName);
            sb.Append(",TblName: ");
            sb.Append(TblName);
            sb.Append(",ColNames: ");
            sb.Append(ColNames);
            sb.Append(",PartNames: ");
            sb.Append(PartNames);
            sb.Append(")");
            return sb.ToString();
        }
    }
}