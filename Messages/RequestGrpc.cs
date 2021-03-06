// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: request.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System;
using grpc = global::Grpc.Core;

namespace TrajectoryServer {
  /// <summary>
  ///======================================
  /// </summary>
  public static partial class DroneService
  {
    static readonly string __ServiceName = "trajectoryServer.DroneService";

    static readonly grpc::Marshaller<global::TrajectoryServer.GetByDroneIdRequest> __Marshaller_trajectoryServer_GetByDroneIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TrajectoryServer.GetByDroneIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TrajectoryServer.DroneResponse> __Marshaller_trajectoryServer_DroneResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TrajectoryServer.DroneResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TrajectoryServer.GetAllRequest> __Marshaller_trajectoryServer_GetAllRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TrajectoryServer.GetAllRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TrajectoryServer.DroneRequest> __Marshaller_trajectoryServer_DroneRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TrajectoryServer.DroneRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TrajectoryServer.SendDroneRequest> __Marshaller_trajectoryServer_SendDroneRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TrajectoryServer.SendDroneRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TrajectoryServer.SendDroneResponse> __Marshaller_trajectoryServer_SendDroneResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TrajectoryServer.SendDroneResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TrajectoryServer.Request> __Marshaller_trajectoryServer_Request = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TrajectoryServer.Request.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TrajectoryServer.Response> __Marshaller_trajectoryServer_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TrajectoryServer.Response.Parser.ParseFrom);

    static readonly grpc::Method<global::TrajectoryServer.GetByDroneIdRequest, global::TrajectoryServer.DroneResponse> __Method_GetByDroneId = new grpc::Method<global::TrajectoryServer.GetByDroneIdRequest, global::TrajectoryServer.DroneResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetByDroneId",
        __Marshaller_trajectoryServer_GetByDroneIdRequest,
        __Marshaller_trajectoryServer_DroneResponse);

    static readonly grpc::Method<global::TrajectoryServer.GetAllRequest, global::TrajectoryServer.DroneResponse> __Method_GetAll = new grpc::Method<global::TrajectoryServer.GetAllRequest, global::TrajectoryServer.DroneResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAll",
        __Marshaller_trajectoryServer_GetAllRequest,
        __Marshaller_trajectoryServer_DroneResponse);

    static readonly grpc::Method<global::TrajectoryServer.DroneRequest, global::TrajectoryServer.DroneResponse> __Method_Save = new grpc::Method<global::TrajectoryServer.DroneRequest, global::TrajectoryServer.DroneResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Save",
        __Marshaller_trajectoryServer_DroneRequest,
        __Marshaller_trajectoryServer_DroneResponse);

    static readonly grpc::Method<global::TrajectoryServer.DroneRequest, global::TrajectoryServer.DroneResponse> __Method_SaveAll = new grpc::Method<global::TrajectoryServer.DroneRequest, global::TrajectoryServer.DroneResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "SaveAll",
        __Marshaller_trajectoryServer_DroneRequest,
        __Marshaller_trajectoryServer_DroneResponse);

    static readonly grpc::Method<global::TrajectoryServer.SendDroneRequest, global::TrajectoryServer.SendDroneResponse> __Method_Send = new grpc::Method<global::TrajectoryServer.SendDroneRequest, global::TrajectoryServer.SendDroneResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Send",
        __Marshaller_trajectoryServer_SendDroneRequest,
        __Marshaller_trajectoryServer_SendDroneResponse);

    static readonly grpc::Method<global::TrajectoryServer.SendDroneRequest, global::TrajectoryServer.SendDroneResponse> __Method_SendAll = new grpc::Method<global::TrajectoryServer.SendDroneRequest, global::TrajectoryServer.SendDroneResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "SendAll",
        __Marshaller_trajectoryServer_SendDroneRequest,
        __Marshaller_trajectoryServer_SendDroneResponse);

    static readonly grpc::Method<global::TrajectoryServer.Request, global::TrajectoryServer.Response> __Method_SendRequest = new grpc::Method<global::TrajectoryServer.Request, global::TrajectoryServer.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendRequest",
        __Marshaller_trajectoryServer_Request,
        __Marshaller_trajectoryServer_Response);

    static readonly grpc::Method<global::TrajectoryServer.Request, global::TrajectoryServer.Response> __Method_SendAllRequest = new grpc::Method<global::TrajectoryServer.Request, global::TrajectoryServer.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "SendAllRequest",
        __Marshaller_trajectoryServer_Request,
        __Marshaller_trajectoryServer_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TrajectoryServer.RequestReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DroneService</summary>
    public abstract partial class DroneServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::TrajectoryServer.DroneResponse> GetByDroneId(global::TrajectoryServer.GetByDroneIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAll(global::TrajectoryServer.GetAllRequest request, grpc::IServerStreamWriter<global::TrajectoryServer.DroneResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TrajectoryServer.DroneResponse> Save(global::TrajectoryServer.DroneRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task SaveAll(grpc::IAsyncStreamReader<global::TrajectoryServer.DroneRequest> requestStream, grpc::IServerStreamWriter<global::TrajectoryServer.DroneResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TrajectoryServer.SendDroneResponse> Send(global::TrajectoryServer.SendDroneRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task SendAll(grpc::IAsyncStreamReader<global::TrajectoryServer.SendDroneRequest> requestStream, grpc::IServerStreamWriter<global::TrajectoryServer.SendDroneResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TrajectoryServer.Response> SendRequest(global::TrajectoryServer.Request request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task SendAllRequest(grpc::IAsyncStreamReader<global::TrajectoryServer.Request> requestStream, grpc::IServerStreamWriter<global::TrajectoryServer.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DroneService</summary>
    public partial class DroneServiceClient : grpc::ClientBase<DroneServiceClient>
    {
      /// <summary>Creates a new client for DroneService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DroneServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DroneService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DroneServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DroneServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DroneServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::TrajectoryServer.DroneResponse GetByDroneId(global::TrajectoryServer.GetByDroneIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByDroneId(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TrajectoryServer.DroneResponse GetByDroneId(global::TrajectoryServer.GetByDroneIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetByDroneId, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TrajectoryServer.DroneResponse> GetByDroneIdAsync(global::TrajectoryServer.GetByDroneIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByDroneIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TrajectoryServer.DroneResponse> GetByDroneIdAsync(global::TrajectoryServer.GetByDroneIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetByDroneId, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::TrajectoryServer.DroneResponse> GetAll(global::TrajectoryServer.GetAllRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::TrajectoryServer.DroneResponse> GetAll(global::TrajectoryServer.GetAllRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAll, null, options, request);
      }
      public virtual global::TrajectoryServer.DroneResponse Save(global::TrajectoryServer.DroneRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Save(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TrajectoryServer.DroneResponse Save(global::TrajectoryServer.DroneRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Save, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TrajectoryServer.DroneResponse> SaveAsync(global::TrajectoryServer.DroneRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SaveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TrajectoryServer.DroneResponse> SaveAsync(global::TrajectoryServer.DroneRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Save, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::TrajectoryServer.DroneRequest, global::TrajectoryServer.DroneResponse> SaveAll(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SaveAll(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::TrajectoryServer.DroneRequest, global::TrajectoryServer.DroneResponse> SaveAll(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_SaveAll, null, options);
      }
      public virtual global::TrajectoryServer.SendDroneResponse Send(global::TrajectoryServer.SendDroneRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Send(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TrajectoryServer.SendDroneResponse Send(global::TrajectoryServer.SendDroneRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Send, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TrajectoryServer.SendDroneResponse> SendAsync(global::TrajectoryServer.SendDroneRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TrajectoryServer.SendDroneResponse> SendAsync(global::TrajectoryServer.SendDroneRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Send, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::TrajectoryServer.SendDroneRequest, global::TrajectoryServer.SendDroneResponse> SendAll(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendAll(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::TrajectoryServer.SendDroneRequest, global::TrajectoryServer.SendDroneResponse> SendAll(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_SendAll, null, options);
      }
      public virtual global::TrajectoryServer.Response SendRequest(global::TrajectoryServer.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TrajectoryServer.Response SendRequest(global::TrajectoryServer.Request request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendRequest, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TrajectoryServer.Response> SendRequestAsync(global::TrajectoryServer.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TrajectoryServer.Response> SendRequestAsync(global::TrajectoryServer.Request request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendRequest, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::TrajectoryServer.Request, global::TrajectoryServer.Response> SendAllRequest(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendAllRequest(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::TrajectoryServer.Request, global::TrajectoryServer.Response> SendAllRequest(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_SendAllRequest, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DroneServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DroneServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DroneServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetByDroneId, serviceImpl.GetByDroneId)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_Save, serviceImpl.Save)
          .AddMethod(__Method_SaveAll, serviceImpl.SaveAll)
          .AddMethod(__Method_Send, serviceImpl.Send)
          .AddMethod(__Method_SendAll, serviceImpl.SendAll)
          .AddMethod(__Method_SendRequest, serviceImpl.SendRequest)
          .AddMethod(__Method_SendAllRequest, serviceImpl.SendAllRequest).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DroneServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetByDroneId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TrajectoryServer.GetByDroneIdRequest, global::TrajectoryServer.DroneResponse>(serviceImpl.GetByDroneId));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::TrajectoryServer.GetAllRequest, global::TrajectoryServer.DroneResponse>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_Save, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TrajectoryServer.DroneRequest, global::TrajectoryServer.DroneResponse>(serviceImpl.Save));
      serviceBinder.AddMethod(__Method_SaveAll, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::TrajectoryServer.DroneRequest, global::TrajectoryServer.DroneResponse>(serviceImpl.SaveAll));
      serviceBinder.AddMethod(__Method_Send, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TrajectoryServer.SendDroneRequest, global::TrajectoryServer.SendDroneResponse>(serviceImpl.Send));
      serviceBinder.AddMethod(__Method_SendAll, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::TrajectoryServer.SendDroneRequest, global::TrajectoryServer.SendDroneResponse>(serviceImpl.SendAll));
      serviceBinder.AddMethod(__Method_SendRequest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TrajectoryServer.Request, global::TrajectoryServer.Response>(serviceImpl.SendRequest));
      serviceBinder.AddMethod(__Method_SendAllRequest, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::TrajectoryServer.Request, global::TrajectoryServer.Response>(serviceImpl.SendAllRequest));
    }

  }
}
#endregion
