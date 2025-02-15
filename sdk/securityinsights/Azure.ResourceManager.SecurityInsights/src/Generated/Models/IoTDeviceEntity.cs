// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents an IoT device entity. </summary>
    public partial class IoTDeviceEntity : EntityData
    {
        /// <summary> Initializes a new instance of IoTDeviceEntity. </summary>
        public IoTDeviceEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            ThreatIntelligence = new ChangeTrackingList<ThreatIntelligence>();
            Protocols = new ChangeTrackingList<string>();
            Owners = new ChangeTrackingList<string>();
            NicEntityIds = new ChangeTrackingList<string>();
            Kind = EntityKind.IoTDevice;
        }

        /// <summary> Initializes a new instance of IoTDeviceEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="deviceId"> The ID of the IoT Device in the IoT Hub. </param>
        /// <param name="deviceName"> The friendly name of the device. </param>
        /// <param name="source"> The source of the device. </param>
        /// <param name="iotSecurityAgentId"> The ID of the security agent running on the device. </param>
        /// <param name="deviceType"> The type of the device. </param>
        /// <param name="vendor"> The vendor of the device. </param>
        /// <param name="edgeId"> The ID of the edge device. </param>
        /// <param name="macAddress"> The MAC address of the device. </param>
        /// <param name="model"> The model of the device. </param>
        /// <param name="serialNumber"> The serial number of the device. </param>
        /// <param name="firmwareVersion"> The firmware version of the device. </param>
        /// <param name="operatingSystem"> The operating system of the device. </param>
        /// <param name="iotHubEntityId"> The AzureResource entity id of the IoT Hub. </param>
        /// <param name="hostEntityId"> The Host entity id of this device. </param>
        /// <param name="ipAddressEntityId"> The IP entity if of this device. </param>
        /// <param name="threatIntelligence"> A list of TI contexts attached to the IoTDevice entity. </param>
        /// <param name="protocols"> A list of protocols of the IoTDevice entity. </param>
        /// <param name="owners"> A list of owners of the IoTDevice entity. </param>
        /// <param name="nicEntityIds"> A list of Nic entity ids of the IoTDevice entity. </param>
        /// <param name="site"> The site of the device. </param>
        /// <param name="zone"> The zone location of the device within a site. </param>
        /// <param name="sensor"> The sensor the device is monitored by. </param>
        /// <param name="deviceSubType"> The subType of the device (&apos;PLC&apos;, &apos;HMI&apos;, &apos;EWS&apos;, etc.). </param>
        /// <param name="importance"> Device importance, determines if the device classified as &apos;crown jewel&apos;. </param>
        /// <param name="purdueLayer"> The Purdue Layer of the device. </param>
        /// <param name="isAuthorized"> Determines whether the device classified as authorized device. </param>
        /// <param name="isProgramming"> Determines whether the device classified as programming device. </param>
        /// <param name="isScanner"> Is the device classified as a scanner device. </param>
        internal IoTDeviceEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string deviceId, string deviceName, string source, Guid? iotSecurityAgentId, string deviceType, string vendor, string edgeId, string macAddress, string model, string serialNumber, string firmwareVersion, string operatingSystem, string iotHubEntityId, string hostEntityId, string ipAddressEntityId, IReadOnlyList<ThreatIntelligence> threatIntelligence, IReadOnlyList<string> protocols, IReadOnlyList<string> owners, IReadOnlyList<string> nicEntityIds, string site, string zone, string sensor, string deviceSubType, DeviceImportance? importance, string purdueLayer, bool? isAuthorized, bool? isProgramming, bool? isScanner) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            DeviceId = deviceId;
            DeviceName = deviceName;
            Source = source;
            IotSecurityAgentId = iotSecurityAgentId;
            DeviceType = deviceType;
            Vendor = vendor;
            EdgeId = edgeId;
            MacAddress = macAddress;
            Model = model;
            SerialNumber = serialNumber;
            FirmwareVersion = firmwareVersion;
            OperatingSystem = operatingSystem;
            IotHubEntityId = iotHubEntityId;
            HostEntityId = hostEntityId;
            IPAddressEntityId = ipAddressEntityId;
            ThreatIntelligence = threatIntelligence;
            Protocols = protocols;
            Owners = owners;
            NicEntityIds = nicEntityIds;
            Site = site;
            Zone = zone;
            Sensor = sensor;
            DeviceSubType = deviceSubType;
            Importance = importance;
            PurdueLayer = purdueLayer;
            IsAuthorized = isAuthorized;
            IsProgramming = isProgramming;
            IsScanner = isScanner;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The ID of the IoT Device in the IoT Hub. </summary>
        public string DeviceId { get; }
        /// <summary> The friendly name of the device. </summary>
        public string DeviceName { get; }
        /// <summary> The source of the device. </summary>
        public string Source { get; }
        /// <summary> The ID of the security agent running on the device. </summary>
        public Guid? IotSecurityAgentId { get; }
        /// <summary> The type of the device. </summary>
        public string DeviceType { get; }
        /// <summary> The vendor of the device. </summary>
        public string Vendor { get; }
        /// <summary> The ID of the edge device. </summary>
        public string EdgeId { get; }
        /// <summary> The MAC address of the device. </summary>
        public string MacAddress { get; }
        /// <summary> The model of the device. </summary>
        public string Model { get; }
        /// <summary> The serial number of the device. </summary>
        public string SerialNumber { get; }
        /// <summary> The firmware version of the device. </summary>
        public string FirmwareVersion { get; }
        /// <summary> The operating system of the device. </summary>
        public string OperatingSystem { get; }
        /// <summary> The AzureResource entity id of the IoT Hub. </summary>
        public string IotHubEntityId { get; }
        /// <summary> The Host entity id of this device. </summary>
        public string HostEntityId { get; }
        /// <summary> The IP entity if of this device. </summary>
        public string IPAddressEntityId { get; }
        /// <summary> A list of TI contexts attached to the IoTDevice entity. </summary>
        public IReadOnlyList<ThreatIntelligence> ThreatIntelligence { get; }
        /// <summary> A list of protocols of the IoTDevice entity. </summary>
        public IReadOnlyList<string> Protocols { get; }
        /// <summary> A list of owners of the IoTDevice entity. </summary>
        public IReadOnlyList<string> Owners { get; }
        /// <summary> A list of Nic entity ids of the IoTDevice entity. </summary>
        public IReadOnlyList<string> NicEntityIds { get; }
        /// <summary> The site of the device. </summary>
        public string Site { get; }
        /// <summary> The zone location of the device within a site. </summary>
        public string Zone { get; }
        /// <summary> The sensor the device is monitored by. </summary>
        public string Sensor { get; }
        /// <summary> The subType of the device (&apos;PLC&apos;, &apos;HMI&apos;, &apos;EWS&apos;, etc.). </summary>
        public string DeviceSubType { get; }
        /// <summary> Device importance, determines if the device classified as &apos;crown jewel&apos;. </summary>
        public DeviceImportance? Importance { get; set; }
        /// <summary> The Purdue Layer of the device. </summary>
        public string PurdueLayer { get; }
        /// <summary> Determines whether the device classified as authorized device. </summary>
        public bool? IsAuthorized { get; }
        /// <summary> Determines whether the device classified as programming device. </summary>
        public bool? IsProgramming { get; }
        /// <summary> Is the device classified as a scanner device. </summary>
        public bool? IsScanner { get; }
    }
}
