// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: productservice.proto
// Original file comments:
// Copyright 2015, Google Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Inman.Platform.ServiceStub {
  /// <summary>
  ///  The greeting service definition.
  /// </summary>
  public static class ProductService
  {
    static readonly string __ServiceName = "ProductService";

    static readonly Marshaller<global::Inman.Platform.ServiceStub.ProductRequest> __Marshaller_ProductRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Inman.Platform.ServiceStub.ProductRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Inman.Platform.ServiceStub.Data.Product> __Marshaller_Product = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Inman.Platform.ServiceStub.Data.Product.Parser.ParseFrom);
    static readonly Marshaller<global::Inman.Platform.ServiceStub.ProductResponse> __Marshaller_ProductResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Inman.Platform.ServiceStub.ProductResponse.Parser.ParseFrom);

    static readonly Method<global::Inman.Platform.ServiceStub.ProductRequest, global::Inman.Platform.ServiceStub.Data.Product> __Method_GetProduct = new Method<global::Inman.Platform.ServiceStub.ProductRequest, global::Inman.Platform.ServiceStub.Data.Product>(
        MethodType.Unary,
        __ServiceName,
        "GetProduct",
        __Marshaller_ProductRequest,
        __Marshaller_Product);

    static readonly Method<global::Inman.Platform.ServiceStub.ProductRequest, global::Inman.Platform.ServiceStub.ProductResponse> __Method_GetProductList = new Method<global::Inman.Platform.ServiceStub.ProductRequest, global::Inman.Platform.ServiceStub.ProductResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetProductList",
        __Marshaller_ProductRequest,
        __Marshaller_ProductResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Inman.Platform.ServiceStub.ProductserviceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductService</summary>
    public abstract class ProductServiceBase
    {
      /// <summary>
      ///  Sends a greeting
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Inman.Platform.ServiceStub.Data.Product> GetProduct(global::Inman.Platform.ServiceStub.ProductRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Inman.Platform.ServiceStub.ProductResponse> GetProductList(global::Inman.Platform.ServiceStub.ProductRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProductService</summary>
    public class ProductServiceClient : ClientBase<ProductServiceClient>
    {
      /// <summary>Creates a new client for ProductService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProductServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProductServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProductServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProductServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Sends a greeting
      /// </summary>
      public virtual global::Inman.Platform.ServiceStub.Data.Product GetProduct(global::Inman.Platform.ServiceStub.ProductRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetProduct(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Sends a greeting
      /// </summary>
      public virtual global::Inman.Platform.ServiceStub.Data.Product GetProduct(global::Inman.Platform.ServiceStub.ProductRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProduct, null, options, request);
      }
      /// <summary>
      ///  Sends a greeting
      /// </summary>
      public virtual AsyncUnaryCall<global::Inman.Platform.ServiceStub.Data.Product> GetProductAsync(global::Inman.Platform.ServiceStub.ProductRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetProductAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Sends a greeting
      /// </summary>
      public virtual AsyncUnaryCall<global::Inman.Platform.ServiceStub.Data.Product> GetProductAsync(global::Inman.Platform.ServiceStub.ProductRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProduct, null, options, request);
      }
      public virtual global::Inman.Platform.ServiceStub.ProductResponse GetProductList(global::Inman.Platform.ServiceStub.ProductRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetProductList(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Inman.Platform.ServiceStub.ProductResponse GetProductList(global::Inman.Platform.ServiceStub.ProductRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductList, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Inman.Platform.ServiceStub.ProductResponse> GetProductListAsync(global::Inman.Platform.ServiceStub.ProductRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetProductListAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Inman.Platform.ServiceStub.ProductResponse> GetProductListAsync(global::Inman.Platform.ServiceStub.ProductRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductList, null, options, request);
      }
      protected override ProductServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ProductServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProduct, serviceImpl.GetProduct)
          .AddMethod(__Method_GetProductList, serviceImpl.GetProductList).Build();
    }

  }
}
#endregion