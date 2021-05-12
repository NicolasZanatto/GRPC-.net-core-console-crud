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

    /// <summary>Client for Greeter</summary>
    public partial class GreeterClient : grpc::ClientBase<GreeterClient>
    {
      /// <summary>Creates a new client for Greeter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreeterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Greeter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreeterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreeterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreeterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Protos.LivroReply CriarLivro(global::Protos.CriarLivroRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CriarLivro(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Protos.LivroReply CriarLivro(global::Protos.CriarLivroRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CriarLivro, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> CriarLivroAsync(global::Protos.CriarLivroRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CriarLivroAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> CriarLivroAsync(global::Protos.CriarLivroRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CriarLivro, null, options, request);
      }
      public virtual global::Protos.LivroReply AtualizarLivro(global::Protos.AtualizarLivroRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AtualizarLivro(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protos.LivroReply AtualizarLivro(global::Protos.AtualizarLivroRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AtualizarLivro, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> AtualizarLivroAsync(global::Protos.AtualizarLivroRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AtualizarLivroAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> AtualizarLivroAsync(global::Protos.AtualizarLivroRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AtualizarLivro, null, options, request);
      }
      public virtual global::Protos.LivroReply RemoverLivro(global::Protos.RemoverLivroRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoverLivro(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protos.LivroReply RemoverLivro(global::Protos.RemoverLivroRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoverLivro, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> RemoverLivroAsync(global::Protos.RemoverLivroRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoverLivroAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> RemoverLivroAsync(global::Protos.RemoverLivroRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoverLivro, null, options, request);
      }
      public virtual global::Protos.LivroReply ConsultarLivroPorTitulo(global::Protos.ConsultarLivroPorTituloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConsultarLivroPorTitulo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protos.LivroReply ConsultarLivroPorTitulo(global::Protos.ConsultarLivroPorTituloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ConsultarLivroPorTitulo, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> ConsultarLivroPorTituloAsync(global::Protos.ConsultarLivroPorTituloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConsultarLivroPorTituloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> ConsultarLivroPorTituloAsync(global::Protos.ConsultarLivroPorTituloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ConsultarLivroPorTitulo, null, options, request);
      }
      public virtual global::Protos.LivroReply ConsultarPorAnoENumero(global::Protos.ConsultarPorAnoENumeroRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConsultarPorAnoENumero(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protos.LivroReply ConsultarPorAnoENumero(global::Protos.ConsultarPorAnoENumeroRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ConsultarPorAnoENumero, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> ConsultarPorAnoENumeroAsync(global::Protos.ConsultarPorAnoENumeroRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConsultarPorAnoENumeroAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protos.LivroReply> ConsultarPorAnoENumeroAsync(global::Protos.ConsultarPorAnoENumeroRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ConsultarPorAnoENumero, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GreeterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreeterClient(configuration);
      }
    }

  }
}
#endregion