// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;
    

    /// <summary>
    /// resource
    /// </summary>
    public partial class MicrosoftDynamicsCRMresource
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresource
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresource
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresource(long? entityimageTimestamp = default(long?), bool? isdisabled = default(bool?), string entityimageUrl = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string objecttypecode = default(string), string _organizationidValue = default(string), bool? displayinserviceviews = default(bool?), object entityimage = default(object), string _siteidValue = default(string), string name = default(string), string calendarid = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), long? versionnumber = default(long?), int? importsequencenumber = default(int?), string _businessunitidValue = default(string), string entityimageid = default(string), string resourceid = default(string), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> resourceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> resourceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> resourceMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> resourceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> resourcePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMequipment resourceidEquipment = default(MicrosoftDynamicsCRMequipment), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMresourcespec resourceidResourcespec = default(MicrosoftDynamicsCRMresourcespec), MicrosoftDynamicsCRMsystemuser resourceidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsite siteid = default(MicrosoftDynamicsCRMsite))
        {
            EntityimageTimestamp = entityimageTimestamp;
            Isdisabled = isdisabled;
            EntityimageUrl = entityimageUrl;
            Overriddencreatedon = overriddencreatedon;
            Objecttypecode = objecttypecode;
            this._organizationidValue = _organizationidValue;
            Displayinserviceviews = displayinserviceviews;
            Entityimage = entityimage;
            this._siteidValue = _siteidValue;
            Name = name;
            Calendarid = calendarid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            this._businessunitidValue = _businessunitidValue;
            Entityimageid = entityimageid;
            Resourceid = resourceid;
            Businessunitid = businessunitid;
            ResourceSyncErrors = resourceSyncErrors;
            ResourceAsyncOperations = resourceAsyncOperations;
            ResourceMailboxTrackingFolders = resourceMailboxTrackingFolders;
            ResourceBulkDeleteFailures = resourceBulkDeleteFailures;
            ResourcePrincipalObjectAttributeAccesses = resourcePrincipalObjectAttributeAccesses;
            ResourceidEquipment = resourceidEquipment;
            Organizationid = organizationid;
            ResourceidResourcespec = resourceidResourcespec;
            ResourceidSystemuser = resourceidSystemuser;
            Siteid = siteid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdisabled")]
        public bool? Isdisabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayinserviceviews")]
        public bool? Displayinserviceviews { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        [NotMapped] public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_siteid_value")]
        public string _siteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public string Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceid")]
        public string Resourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resource_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> ResourceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resource_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> ResourceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ResourceMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resource_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> ResourceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ResourcePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceid_equipment")]
        public MicrosoftDynamicsCRMequipment ResourceidEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceid_resourcespec")]
        public MicrosoftDynamicsCRMresourcespec ResourceidResourcespec { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser ResourceidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteid")]
        public MicrosoftDynamicsCRMsite Siteid { get; set; }

    }
}