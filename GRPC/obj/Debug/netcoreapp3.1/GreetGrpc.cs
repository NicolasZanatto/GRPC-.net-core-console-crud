// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Protos {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "greet.Greeter";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::Protos.CriarLivroRequest> __Marshaller_greet_CriarLivroRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protos.CriarLivroRequest.Parser));
    static readonly grpc::Marshaller<global::Protos.LivroReply> __Marshaller_greet_LivroReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protos.LivroReply.Parser));
    static readonly grpc::Marshaller<global::Protos.AtualizarLivroRequest> __Marshaller_greet_AtualizarLivroRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protos.AtualizarLivroRequest.Parser));
    static readonly grpc::Marshaller<global::Protos.RemoverLivroRequest> __Marshaller_greet_RemoverLivroRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protos.RemoverLivroRequest.Parser));
    static readonly grpc::Marshaller<global::Protos.ConsultarLivroPorTituloRequest> __Marshaller_greet_ConsultarLivroPorTituloRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protos.ConsultarLivroPorTituloRequest.Parser));
    static readonly grpc::Marshaller<global::Protos.ConsultarPorAnoENumeroRequest> __Marshaller_greet_ConsultarPorAnoENumeroRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protos.ConsultarPorAnoENumeroRequest.Parser));

    static readonly grpc::Method<global::Protos.CriarLivroRequest, global::Protos.LivroReply> __Method_CriarLivro = new grpc::Method<global::Protos.CriarLivroRequest, global::Protos.LivroReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CriarLivro",
        __Marshaller_greet_CriarLivroRequest,
        __Marshaller_greet_LivroReply);

    static readonly grpc::Method<global::Protos.AtualizarLivroRequest, global::Protos.LivroReply> __Method_AtualizarLivro = new grpc::Method<global::Protos.AtualizarLivroRequest, global::Protos.LivroReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AtualizarLivro",
        __Marshaller_greet_AtualizarLivroRequest,
        __Marshaller_greet_LivroReply);

    static readonly grpc::Method<global::Protos.RemoverLivroRequest, global::Protos.LivroReply> __Method_RemoverLivro = new grpc::Method<global::Protos.RemoverLivroRequest, global::Protos.LivroReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoverLivro",
        __Marshaller_greet_RemoverLivroRequest,
        __Marshaller_greet_LivroReply);

    static readonly grpc::Method<global::Protos.ConsultarLivroPorTituloRequest, global::Protos.LivroReply> __Method_ConsultarLivroPorTitulo = new grpc::Method<global::Protos.ConsultarLivroPorTituloRequest, global::Protos.LivroReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ConsultarLivroPorTitulo",
        __Marshaller_greet_ConsultarLivroPorTituloRequest,
        __Marshaller_greet_LivroReply);

    static readonly grpc::Method<global::Protos.ConsultarPorAnoENumeroRequest, global::Protos.LivroReply> __Method_ConsultarPorAnoENumero = new grpc::Method<global::Protos.ConsultarPorAnoENumeroRequest, global::Protos.LivroReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ConsultarPorAnoENumero",
        __Marshaller_greet_ConsultarPorAnoENumeroRequest,
        __Marshaller_greet_LivroReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Protos.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Protos.LivroReply> CriarLivro(global::Protos.CriarLivroRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protos.LivroReply> AtualizarLivro(global::Protos.AtualizarLivroRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protos.LivroReply> RemoverLivro(global::Protos.RemoverLivroRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protos.LivroReply> ConsultarLivroPorTitulo(global::Protos.ConsultarLivroPorTituloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protos.LivroReply> ConsultarPorAnoENumero(global::Protos.ConsultarPorAnoENumeroRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CriarLivro, serviceImpl.CriarLivro)
          .AddMethod(__Method_AtualizarLivro, serviceImpl.AtualizarLivro)
          .AddMethod(__Method_RemoverLivro, serviceImpl.RemoverLivro)
          .AddMethod(__Method_ConsultarLivroPorTitulo, serviceImpl.ConsultarLivroPorTitulo)
          .AddMethod(__Method_ConsultarPorAnoENumero, serviceImpl.ConsultarPorAnoENumero).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CriarLivro, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Protos.CriarLivroRequest, global::Protos.LivroReply>(serviceImpl.CriarLivro));
      serviceBinder.AddMethod(__Method_AtualizarLivro, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Protos.AtualizarLivroRequest, global::Protos.LivroReply>(serviceImpl.AtualizarLivro));
      serviceBinder.AddMethod(__Method_RemoverLivro, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Protos.RemoverLivroRequest, global::Protos.LivroReply>(serviceImpl.RemoverLivro));
      serviceBinder.AddMethod(__Method_ConsultarLivroPorTitulo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Protos.ConsultarLivroPorTituloRequest, global::Protos.LivroReply>(serviceImpl.ConsultarLivroPorTitulo));
      serviceBinder.AddMethod(__Method_ConsultarPorAnoENumero, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Protos.ConsultarPorAnoENumeroRequest, global::Protos.LivroReply>(serviceImpl.ConsultarPorAnoENumero));
    }

  }
}
#endregion
