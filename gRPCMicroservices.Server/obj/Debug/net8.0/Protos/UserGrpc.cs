// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/user.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPCMicroservices.Server {
  public static partial class User
  {
    static readonly string __ServiceName = "User";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCMicroservices.Server.GetUserRequest> __Marshaller_GetUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCMicroservices.Server.GetUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCMicroservices.Server.GetUserResponse> __Marshaller_GetUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCMicroservices.Server.GetUserResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCMicroservices.Server.GetAllUsersRequest> __Marshaller_GetAllUsersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCMicroservices.Server.GetAllUsersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCMicroservices.Server.GetAllUsersResponse> __Marshaller_GetAllUsersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCMicroservices.Server.GetAllUsersResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCMicroservices.Server.CreateUserRequest> __Marshaller_CreateUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCMicroservices.Server.CreateUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCMicroservices.Server.CreateUserResponse> __Marshaller_CreateUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCMicroservices.Server.CreateUserResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCMicroservices.Server.GetUserRequest, global::gRPCMicroservices.Server.GetUserResponse> __Method_GetUserById = new grpc::Method<global::gRPCMicroservices.Server.GetUserRequest, global::gRPCMicroservices.Server.GetUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserById",
        __Marshaller_GetUserRequest,
        __Marshaller_GetUserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCMicroservices.Server.GetAllUsersRequest, global::gRPCMicroservices.Server.GetAllUsersResponse> __Method_GetAllUsers = new grpc::Method<global::gRPCMicroservices.Server.GetAllUsersRequest, global::gRPCMicroservices.Server.GetAllUsersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllUsers",
        __Marshaller_GetAllUsersRequest,
        __Marshaller_GetAllUsersResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCMicroservices.Server.CreateUserRequest, global::gRPCMicroservices.Server.CreateUserResponse> __Method_CreateUser = new grpc::Method<global::gRPCMicroservices.Server.CreateUserRequest, global::gRPCMicroservices.Server.CreateUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateUser",
        __Marshaller_CreateUserRequest,
        __Marshaller_CreateUserResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPCMicroservices.Server.UserReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of User</summary>
    [grpc::BindServiceMethod(typeof(User), "BindService")]
    public abstract partial class UserBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPCMicroservices.Server.GetUserResponse> GetUserById(global::gRPCMicroservices.Server.GetUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPCMicroservices.Server.GetAllUsersResponse> GetAllUsers(global::gRPCMicroservices.Server.GetAllUsersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPCMicroservices.Server.CreateUserResponse> CreateUser(global::gRPCMicroservices.Server.CreateUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UserBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetUserById, serviceImpl.GetUserById)
          .AddMethod(__Method_GetAllUsers, serviceImpl.GetAllUsers)
          .AddMethod(__Method_CreateUser, serviceImpl.CreateUser).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetUserById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCMicroservices.Server.GetUserRequest, global::gRPCMicroservices.Server.GetUserResponse>(serviceImpl.GetUserById));
      serviceBinder.AddMethod(__Method_GetAllUsers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCMicroservices.Server.GetAllUsersRequest, global::gRPCMicroservices.Server.GetAllUsersResponse>(serviceImpl.GetAllUsers));
      serviceBinder.AddMethod(__Method_CreateUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCMicroservices.Server.CreateUserRequest, global::gRPCMicroservices.Server.CreateUserResponse>(serviceImpl.CreateUser));
    }

  }
}
#endregion
