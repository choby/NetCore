// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: userservice.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Inman.Platform.ServiceStub {

  /// <summary>Holder for reflection information generated from userservice.proto</summary>
  public static partial class UserserviceReflection {

    #region Descriptor
    /// <summary>File descriptor for userservice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserserviceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChF1c2Vyc2VydmljZS5wcm90bxoKZGF0YS5wcm90byIwCgpMb2dpblN0dWZm",
            "EhAKCFVzZXJOYW1lGAEgASgJEhAKCFBhc3N3b3JkGAIgASgJIjMKC0xvZ2lu",
            "UmVzdWx0Eg8KB1N1Y2Nlc3MYASABKAgSEwoEVXNlchgCIAEoCzIFLlVzZXIy",
            "OwoLVXNlclNlcnZpY2USLAoNTG9naW5WYWxpZGF0ZRILLkxvZ2luU3R1ZmYa",
            "DC5Mb2dpblJlc3VsdCIAQh2qAhpJbm1hbi5QbGF0Zm9ybS5TZXJ2aWNlU3R1",
            "YmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Inman.Platform.ServiceStub.Data.DataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Inman.Platform.ServiceStub.LoginStuff), global::Inman.Platform.ServiceStub.LoginStuff.Parser, new[]{ "UserName", "Password" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Inman.Platform.ServiceStub.LoginResult), global::Inman.Platform.ServiceStub.LoginResult.Parser, new[]{ "Success", "User" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  The request message containing the user's name.
  /// </summary>
  public sealed partial class LoginStuff : pb::IMessage<LoginStuff> {
    private static readonly pb::MessageParser<LoginStuff> _parser = new pb::MessageParser<LoginStuff>(() => new LoginStuff());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginStuff> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Inman.Platform.ServiceStub.UserserviceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginStuff() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginStuff(LoginStuff other) : this() {
      userName_ = other.userName_;
      password_ = other.password_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginStuff Clone() {
      return new LoginStuff(this);
    }

    /// <summary>Field number for the "UserName" field.</summary>
    public const int UserNameFieldNumber = 1;
    private string userName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginStuff);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginStuff other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserName != other.UserName) return false;
      if (Password != other.Password) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserName);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginStuff other) {
      if (other == null) {
        return;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            UserName = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The response message containing the greetings
  /// </summary>
  public sealed partial class LoginResult : pb::IMessage<LoginResult> {
    private static readonly pb::MessageParser<LoginResult> _parser = new pb::MessageParser<LoginResult>(() => new LoginResult());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Inman.Platform.ServiceStub.UserserviceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginResult(LoginResult other) : this() {
      success_ = other.success_;
      User = other.user_ != null ? other.User.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginResult Clone() {
      return new LoginResult(this);
    }

    /// <summary>Field number for the "Success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "User" field.</summary>
    public const int UserFieldNumber = 2;
    private global::Inman.Platform.ServiceStub.Data.User user_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Inman.Platform.ServiceStub.Data.User User {
      get { return user_; }
      set {
        user_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if (!object.Equals(User, other.User)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      if (user_ != null) hash ^= User.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (user_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(User);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (user_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(User);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginResult other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      if (other.user_ != null) {
        if (user_ == null) {
          user_ = new global::Inman.Platform.ServiceStub.Data.User();
        }
        User.MergeFrom(other.User);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
          case 18: {
            if (user_ == null) {
              user_ = new global::Inman.Platform.ServiceStub.Data.User();
            }
            input.ReadMessage(user_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
