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


namespace Inman.Platform.ServiceStub.Thrift
{

  public partial class GoodsRequest : TBase
  {
    private int _Quantity;
    private THashSet<int> _GoodsId;

    public int Quantity
    {
      get
      {
        return _Quantity;
      }
      set
      {
        __isset.Quantity = true;
        this._Quantity = value;
      }
    }

    public THashSet<int> GoodsId
    {
      get
      {
        return _GoodsId;
      }
      set
      {
        __isset.GoodsId = true;
        this._GoodsId = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool Quantity;
      public bool GoodsId;
    }

    public GoodsRequest()
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
                Quantity = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Set)
              {
                {
                  GoodsId = new THashSet<int>();
                  TSet _set0 = await iprot.ReadSetBeginAsync(cancellationToken);
                  for(int _i1 = 0; _i1 < _set0.Count; ++_i1)
                  {
                    int _elem2;
                    _elem2 = await iprot.ReadI32Async(cancellationToken);
                    GoodsId.Add(_elem2);
                  }
                  await iprot.ReadSetEndAsync(cancellationToken);
                }
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
        var struc = new TStruct("GoodsRequest");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (__isset.Quantity)
        {
          field.Name = "Quantity";
          field.Type = TType.I32;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(Quantity, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (GoodsId != null && __isset.GoodsId)
        {
          field.Name = "GoodsId";
          field.Type = TType.Set;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteSetBeginAsync(new TSet(TType.I32, GoodsId.Count), cancellationToken);
            foreach (int _iter3 in GoodsId)
            {
              await oprot.WriteI32Async(_iter3, cancellationToken);
            }
            await oprot.WriteSetEndAsync(cancellationToken);
          }
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
      var sb = new StringBuilder("GoodsRequest(");
      bool __first = true;
      if (__isset.Quantity)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Quantity: ");
        sb.Append(Quantity);
      }
      if (GoodsId != null && __isset.GoodsId)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("GoodsId: ");
        sb.Append(GoodsId);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
