// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: exporter/exporter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Opencensus.Proto.Exporter {

  /// <summary>Holder for reflection information generated from exporter/exporter.proto</summary>
  public static partial class ExporterReflection {

    #region Descriptor
    /// <summary>File descriptor for exporter/exporter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExporterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdleHBvcnRlci9leHBvcnRlci5wcm90bxIZb3BlbmNlbnN1cy5wcm90by5l",
            "eHBvcnRlchoib3BlbmNlbnN1cy9wcm90by90cmFjZS90cmFjZS5wcm90byJA",
            "ChFFeHBvcnRTcGFuUmVxdWVzdBIrCgVzcGFucxgBIAMoCzIcLm9wZW5jZW5z",
            "dXMucHJvdG8udHJhY2UuU3BhbiIUChJFeHBvcnRTcGFuUmVzcG9uc2UygwEK",
            "EE9wZW5DZW5zdXNFeHBvcnQSbwoKRXhwb3J0U3BhbhIsLm9wZW5jZW5zdXMu",
            "cHJvdG8uZXhwb3J0ZXIuRXhwb3J0U3BhblJlcXVlc3QaLS5vcGVuY2Vuc3Vz",
            "LnByb3RvLmV4cG9ydGVyLkV4cG9ydFNwYW5SZXNwb25zZSIAKAEwAUJ4Chxp",
            "by5vcGVuY2Vuc3VzLnByb3RvLmV4cG9ydGVyQg1FeHBvcnRlclByb3RvUAFa",
            "R2dpdGh1Yi5jb20vY2Vuc3VzLWluc3RydW1lbnRhdGlvbi9vcGVuY2Vuc3Vz",
            "LXByb3RvL2dlbi1nby9leHBvcnRlcnByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Opencensus.Proto.Trace.TraceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Exporter.ExportSpanRequest), global::Opencensus.Proto.Exporter.ExportSpanRequest.Parser, new[]{ "Spans" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Exporter.ExportSpanResponse), global::Opencensus.Proto.Exporter.ExportSpanResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ExportSpanRequest : pb::IMessage<ExportSpanRequest> {
    private static readonly pb::MessageParser<ExportSpanRequest> _parser = new pb::MessageParser<ExportSpanRequest>(() => new ExportSpanRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExportSpanRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Exporter.ExporterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportSpanRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportSpanRequest(ExportSpanRequest other) : this() {
      spans_ = other.spans_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportSpanRequest Clone() {
      return new ExportSpanRequest(this);
    }

    /// <summary>Field number for the "spans" field.</summary>
    public const int SpansFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Opencensus.Proto.Trace.Span> _repeated_spans_codec
        = pb::FieldCodec.ForMessage(10, global::Opencensus.Proto.Trace.Span.Parser);
    private readonly pbc::RepeatedField<global::Opencensus.Proto.Trace.Span> spans_ = new pbc::RepeatedField<global::Opencensus.Proto.Trace.Span>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Opencensus.Proto.Trace.Span> Spans {
      get { return spans_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExportSpanRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExportSpanRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!spans_.Equals(other.spans_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= spans_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      spans_.WriteTo(output, _repeated_spans_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += spans_.CalculateSize(_repeated_spans_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExportSpanRequest other) {
      if (other == null) {
        return;
      }
      spans_.Add(other.spans_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            spans_.AddEntriesFrom(input, _repeated_spans_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExportSpanResponse : pb::IMessage<ExportSpanResponse> {
    private static readonly pb::MessageParser<ExportSpanResponse> _parser = new pb::MessageParser<ExportSpanResponse>(() => new ExportSpanResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExportSpanResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Exporter.ExporterReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportSpanResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportSpanResponse(ExportSpanResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportSpanResponse Clone() {
      return new ExportSpanResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExportSpanResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExportSpanResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExportSpanResponse other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
