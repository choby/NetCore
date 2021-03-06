/**
 * Autogenerated by Thrift Compiler (@PACKAGE_VERSION@)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;


namespace Inman.Platform.ServiceStub.Thrift.Data
{

  public partial class User : TBase
  {
    private int _Id;
    private string _OpenId;
    private string _UserName;

    public int Id
    {
      get
      {
        return _Id;
      }
      set
      {
        __isset.Id = true;
        this._Id = value;
      }
    }

    public string OpenId
    {
      get
      {
        return _OpenId;
      }
      set
      {
        __isset.OpenId = true;
        this._OpenId = value;
      }
    }

    public string UserName
    {
      get
      {
        return _UserName;
      }
      set
      {
        __isset.UserName = true;
        this._UserName = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool Id;
      public bool OpenId;
      public bool UserName;
    }

    public User()
    {
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                OpenId = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                UserName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("User");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (__isset.Id)
        {
          field.Name = "Id";
          field.Type = TType.I32;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(Id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (OpenId != null && __isset.OpenId)
        {
          field.Name = "OpenId";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(OpenId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (UserName != null && __isset.UserName)
        {
          field.Name = "UserName";
          field.Type = TType.String;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(UserName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder("User(");
      bool __first = true;
      if (__isset.Id)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Id: ");
        sb.Append(Id);
      }
      if (OpenId != null && __isset.OpenId)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("OpenId: ");
        sb.Append(OpenId);
      }
      if (UserName != null && __isset.UserName)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("UserName: ");
        sb.Append(UserName);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
