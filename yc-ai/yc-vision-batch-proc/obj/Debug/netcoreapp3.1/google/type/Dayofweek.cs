// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/type/dayofweek.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  /// <summary>Holder for reflection information generated from google/type/dayofweek.proto</summary>
  public static partial class DayofweekReflection {

    #region Descriptor
    /// <summary>File descriptor for google/type/dayofweek.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DayofweekReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtnb29nbGUvdHlwZS9kYXlvZndlZWsucHJvdG8SC2dvb2dsZS50eXBlKoQB",
            "CglEYXlPZldlZWsSGwoXREFZX09GX1dFRUtfVU5TUEVDSUZJRUQQABIKCgZN",
            "T05EQVkQARILCgdUVUVTREFZEAISDQoJV0VETkVTREFZEAMSDAoIVEhVUlNE",
            "QVkQBBIKCgZGUklEQVkQBRIMCghTQVRVUkRBWRAGEgoKBlNVTkRBWRAHQmkK",
            "D2NvbS5nb29nbGUudHlwZUIORGF5T2ZXZWVrUHJvdG9QAVo+Z29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy90eXBlL2RheW9md2Vlaztk",
            "YXlvZndlZWuiAgNHVFBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Type.DayOfWeek), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Represents a day of week.
  /// </summary>
  public enum DayOfWeek {
    /// <summary>
    /// The unspecified day-of-week.
    /// </summary>
    [pbr::OriginalName("DAY_OF_WEEK_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The day-of-week of Monday.
    /// </summary>
    [pbr::OriginalName("MONDAY")] Monday = 1,
    /// <summary>
    /// The day-of-week of Tuesday.
    /// </summary>
    [pbr::OriginalName("TUESDAY")] Tuesday = 2,
    /// <summary>
    /// The day-of-week of Wednesday.
    /// </summary>
    [pbr::OriginalName("WEDNESDAY")] Wednesday = 3,
    /// <summary>
    /// The day-of-week of Thursday.
    /// </summary>
    [pbr::OriginalName("THURSDAY")] Thursday = 4,
    /// <summary>
    /// The day-of-week of Friday.
    /// </summary>
    [pbr::OriginalName("FRIDAY")] Friday = 5,
    /// <summary>
    /// The day-of-week of Saturday.
    /// </summary>
    [pbr::OriginalName("SATURDAY")] Saturday = 6,
    /// <summary>
    /// The day-of-week of Sunday.
    /// </summary>
    [pbr::OriginalName("SUNDAY")] Sunday = 7,
  }

  #endregion

}

#endregion Designer generated code
