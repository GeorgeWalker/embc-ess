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
    /// campaignactivityitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMcampaignactivityitem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcampaignactivityitem class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaignactivityitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcampaignactivityitem class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaignactivityitem(string owninguser = default(string), int? timezoneruleversionnumber = default(int?), string itemobjecttypecode = default(string), string itemid = default(string), string _owneridValue = default(string), string campaignactivityitemid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _campaignactivityidValue = default(string), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), string owningbusinessunit = default(string), IList<MicrosoftDynamicsCRMasyncoperation> campaignactivityitemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> campaignactivityitemMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> campaignactivityitemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> campaignactivityitemPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMactivitypointer campaignactivityid = default(MicrosoftDynamicsCRMactivitypointer))
        {
            Owninguser = owninguser;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Itemobjecttypecode = itemobjecttypecode;
            Itemid = itemid;
            this._owneridValue = _owneridValue;
            Campaignactivityitemid = campaignactivityitemid;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            this._campaignactivityidValue = _campaignactivityidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            Owningbusinessunit = owningbusinessunit;
            CampaignactivityitemAsyncOperations = campaignactivityitemAsyncOperations;
            CampaignactivityitemMailboxTrackingFolders = campaignactivityitemMailboxTrackingFolders;
            CampaignactivityitemBulkDeleteFailures = campaignactivityitemBulkDeleteFailures;
            CampaignactivityitemPrincipalObjectAttributeAccesses = campaignactivityitemPrincipalObjectAttributeAccesses;
            Campaignactivityid = campaignactivityid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemobjecttypecode")]
        public string Itemobjecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemid")]
        public string Itemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivityitemid")]
        public string Campaignactivityitemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_campaignactivityid_value")]
        public string _campaignactivityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivityitem_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> CampaignactivityitemAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivityitem_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CampaignactivityitemMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivityitem_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> CampaignactivityitemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivityitem_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CampaignactivityitemPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivityid")]
        public MicrosoftDynamicsCRMactivitypointer Campaignactivityid { get; set; }

    }
}