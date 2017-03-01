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

    public partial class TArrayTypeEntry : TBase
    {
        public int ObjectTypePtr { get; set; }

        public TArrayTypeEntry()
        {
        }

        public TArrayTypeEntry(int objectTypePtr) : this()
        {
            this.ObjectTypePtr = objectTypePtr;
        }

        public void Read(TProtocol iprot)
        {
            bool isset_objectTypePtr = false;
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
                        if (field.Type == TType.I32)
                        {
                            ObjectTypePtr = iprot.ReadI32();
                            isset_objectTypePtr = true;
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
            if (!isset_objectTypePtr)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("TArrayTypeEntry");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "objectTypePtr";
            field.Type = TType.I32;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            oprot.WriteI32(ObjectTypePtr);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("TArrayTypeEntry(");
            sb.Append("ObjectTypePtr: ");
            sb.Append(ObjectTypePtr);
            sb.Append(")");
            return sb.ToString();
        }
    }
}