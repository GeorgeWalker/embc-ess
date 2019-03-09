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
    /// contactorders
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontactorders
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactorders
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactorders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactorders
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactorders(long? versionnumber = default(long?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string contactorderid = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string contactid = default(string), int? importsequencenumber = default(int?), string salesorderid = default(string), IList<MicrosoftDynamicsCRMasyncoperation> contactordersAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> contactordersMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> contactordersBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> contactordersPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Contactorderid = contactorderid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Contactid = contactid;
            Importsequencenumber = importsequencenumber;
            Salesorderid = salesorderid;
            ContactordersAsyncOperations = contactordersAsyncOperations;
            ContactordersMailboxTrackingFolders = contactordersMailboxTrackingFolders;
            ContactordersBulkDeleteFailures = contactordersBulkDeleteFailures;
            ContactordersPrincipalObjectAttributeAccesses = contactordersPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorderid")]
        public string Contactorderid { get; set; }

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
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public string Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorders_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> ContactordersAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorders_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ContactordersMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorders_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContactordersBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorders_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ContactordersPrincipalObjectAttributeAccesses { get; set; }

    }
}