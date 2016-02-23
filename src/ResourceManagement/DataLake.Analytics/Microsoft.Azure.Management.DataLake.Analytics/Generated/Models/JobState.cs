// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobState
    {
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Compiling")]
        Compiling,
        [EnumMember(Value = "Ended")]
        Ended,
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "Queued")]
        Queued,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Scheduling")]
        Scheduling,
        [EnumMember(Value = "Starting")]
        Starting,
        [EnumMember(Value = "Paused")]
        Paused,
        [EnumMember(Value = "WaitingForCapacity")]
        WaitingForCapacity
    }
}