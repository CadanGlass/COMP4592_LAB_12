// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/student.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace StudentRemote {
  /// <summary>
  /// The student service definition
  /// </summary>
  public static partial class StudentRemote
  {
    static readonly string __ServiceName = "student.StudentRemote";

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
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::StudentRemote.StudentList> __Marshaller_student_StudentList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::StudentRemote.StudentList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::StudentRemote.Student> __Marshaller_student_Student = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::StudentRemote.Student.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::StudentRemote.StudentLookupModel> __Marshaller_student_StudentLookupModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::StudentRemote.StudentLookupModel.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::StudentRemote.StudentList> __Method_GetAllStudents = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::StudentRemote.StudentList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllStudents",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_student_StudentList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::StudentRemote.Student, global::StudentRemote.Student> __Method_AddStudent = new grpc::Method<global::StudentRemote.Student, global::StudentRemote.Student>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddStudent",
        __Marshaller_student_Student,
        __Marshaller_student_Student);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::StudentRemote.Student, global::StudentRemote.Student> __Method_UpdateStudent = new grpc::Method<global::StudentRemote.Student, global::StudentRemote.Student>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateStudent",
        __Marshaller_student_Student,
        __Marshaller_student_Student);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::StudentRemote.StudentLookupModel, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteStudent = new grpc::Method<global::StudentRemote.StudentLookupModel, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteStudent",
        __Marshaller_student_StudentLookupModel,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::StudentRemote.StudentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StudentRemote</summary>
    [grpc::BindServiceMethod(typeof(StudentRemote), "BindService")]
    public abstract partial class StudentRemoteBase
    {
      /// <summary>
      /// Get all students
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::StudentRemote.StudentList> GetAllStudents(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Add a new student
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::StudentRemote.Student> AddStudent(global::StudentRemote.Student request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Update existing student
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::StudentRemote.Student> UpdateStudent(global::StudentRemote.Student request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Delete a student
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteStudent(global::StudentRemote.StudentLookupModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(StudentRemoteBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllStudents, serviceImpl.GetAllStudents)
          .AddMethod(__Method_AddStudent, serviceImpl.AddStudent)
          .AddMethod(__Method_UpdateStudent, serviceImpl.UpdateStudent)
          .AddMethod(__Method_DeleteStudent, serviceImpl.DeleteStudent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StudentRemoteBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllStudents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::StudentRemote.StudentList>(serviceImpl.GetAllStudents));
      serviceBinder.AddMethod(__Method_AddStudent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::StudentRemote.Student, global::StudentRemote.Student>(serviceImpl.AddStudent));
      serviceBinder.AddMethod(__Method_UpdateStudent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::StudentRemote.Student, global::StudentRemote.Student>(serviceImpl.UpdateStudent));
      serviceBinder.AddMethod(__Method_DeleteStudent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::StudentRemote.StudentLookupModel, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteStudent));
    }

  }
}
#endregion