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
    /// entitlementtemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementtemplate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementtemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementtemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementtemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementtemplate(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), System.DateTimeOffset? startdate = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), long? versionnumber = default(long?), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string description = default(string), string _modifiedonbehalfbyValue = default(string), int? importsequencenumber = default(int?), int? allocationtypecode = default(int?), object totalterms = default(object), int? kbaccesslevel = default(int?), string _slaidValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? decreaseremainingon = default(int?), string _createdonbehalfbyValue = default(string), string entitlementtemplateid = default(string), string _transactioncurrencyidValue = default(string), string name = default(string), object exchangerate = default(object), bool? restrictcasecreation = default(bool?), System.DateTimeOffset? enddate = default(System.DateTimeOffset?), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMactivitypointer> entitlementtemplateActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> entitlementTemplateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> entitlementtemplateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> entitlementTemplateMailboxTrackingFolder = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> entitlementtemplateProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementtemplateBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> entitlementtemplatePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> entitlementtemplateAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> entitlementtemplateEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> entitlementtemplateFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> entitlementtemplateLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> entitlementtemplatePhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> entitlementtemplateTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> entitlementtemplateRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> entitlementtemplateSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMannotation> entitlementtemplateAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMincidentresolution> entitlementtemplateIncidentResolutions = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> entitlementtemplateServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMentitlement> entitlementtemplateidRelationShip = default(IList<MicrosoftDynamicsCRMentitlement>), IList<MicrosoftDynamicsCRMentitlementtemplatechannel> entitlementtemplateEntitlementchannelEntitlementtemplateid = default(IList<MicrosoftDynamicsCRMentitlementtemplatechannel>), IList<MicrosoftDynamicsCRMproduct> productEntitlementtemplateAssociation = default(IList<MicrosoftDynamicsCRMproduct>), MicrosoftDynamicsCRMsla slaid = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementtemplateDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementtemplateDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMopportunityclose> entitlementtemplateOpportunityCloses = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> entitlementtemplateOrderCloses = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> entitlementtemplateQuoteCloses = default(IList<MicrosoftDynamicsCRMquoteclose>))
        {
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Startdate = startdate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Description = description;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            Allocationtypecode = allocationtypecode;
            Totalterms = totalterms;
            Kbaccesslevel = kbaccesslevel;
            this._slaidValue = _slaidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Overriddencreatedon = overriddencreatedon;
            Decreaseremainingon = decreaseremainingon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Entitlementtemplateid = entitlementtemplateid;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Name = name;
            Exchangerate = exchangerate;
            Restrictcasecreation = restrictcasecreation;
            Enddate = enddate;
            this._createdbyValue = _createdbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            EntitlementtemplateActivityPointers = entitlementtemplateActivityPointers;
            EntitlementTemplateSyncErrors = entitlementTemplateSyncErrors;
            EntitlementtemplateAsyncOperations = entitlementtemplateAsyncOperations;
            EntitlementTemplateMailboxTrackingFolder = entitlementTemplateMailboxTrackingFolder;
            EntitlementtemplateProcessSession = entitlementtemplateProcessSession;
            EntitlementtemplateBulkDeleteFailures = entitlementtemplateBulkDeleteFailures;
            EntitlementtemplatePrincipalObjectAttributeAccesses = entitlementtemplatePrincipalObjectAttributeAccesses;
            EntitlementtemplateAppointments = entitlementtemplateAppointments;
            EntitlementtemplateEmails = entitlementtemplateEmails;
            EntitlementtemplateFaxes = entitlementtemplateFaxes;
            EntitlementtemplateLetters = entitlementtemplateLetters;
            EntitlementtemplatePhoneCalls = entitlementtemplatePhoneCalls;
            EntitlementtemplateTasks = entitlementtemplateTasks;
            EntitlementtemplateRecurringAppointmentMasters = entitlementtemplateRecurringAppointmentMasters;
            EntitlementtemplateSocialActivities = entitlementtemplateSocialActivities;
            EntitlementtemplateAnnotations = entitlementtemplateAnnotations;
            EntitlementtemplateIncidentResolutions = entitlementtemplateIncidentResolutions;
            EntitlementtemplateServiceAppointments = entitlementtemplateServiceAppointments;
            EntitlementtemplateidRelationShip = entitlementtemplateidRelationShip;
            EntitlementtemplateEntitlementchannelEntitlementtemplateid = entitlementtemplateEntitlementchannelEntitlementtemplateid;
            ProductEntitlementtemplateAssociation = productEntitlementtemplateAssociation;
            Slaid = slaid;
            Transactioncurrencyid = transactioncurrencyid;
            EntitlementtemplateDuplicateMatchingRecord = entitlementtemplateDuplicateMatchingRecord;
            EntitlementtemplateDuplicateBaseRecord = entitlementtemplateDuplicateBaseRecord;
            EntitlementtemplateOpportunityCloses = entitlementtemplateOpportunityCloses;
            EntitlementtemplateOrderCloses = entitlementtemplateOrderCloses;
            EntitlementtemplateQuoteCloses = entitlementtemplateQuoteCloses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        public System.DateTimeOffset? Startdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allocationtypecode")]
        public int? Allocationtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalterms")]
        [NotMapped] public object Totalterms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbaccesslevel")]
        public int? Kbaccesslevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "decreaseremainingon")]
        public int? Decreaseremainingon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateid")]
        public string Entitlementtemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        [NotMapped] public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "restrictcasecreation")]
        public bool? Restrictcasecreation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        public System.DateTimeOffset? Enddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_ActivityPointers")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivitypointer> EntitlementtemplateActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntitlementTemplate_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> EntitlementTemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementtemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntitlementTemplate_MailboxTrackingFolder")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> EntitlementTemplateMailboxTrackingFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> EntitlementtemplateProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementtemplateBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EntitlementtemplatePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Appointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMappointment> EntitlementtemplateAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Emails")]
        [NotMapped] public IList<MicrosoftDynamicsCRMemail> EntitlementtemplateEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Faxes")]
        [NotMapped] public IList<MicrosoftDynamicsCRMfax> EntitlementtemplateFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Letters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMletter> EntitlementtemplateLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_PhoneCalls")]
        [NotMapped] public IList<MicrosoftDynamicsCRMphonecall> EntitlementtemplatePhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Tasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMtask> EntitlementtemplateTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_RecurringAppointmentMasters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> EntitlementtemplateRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_SocialActivities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsocialactivity> EntitlementtemplateSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Annotations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> EntitlementtemplateAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_IncidentResolutions")]
        [NotMapped] public IList<MicrosoftDynamicsCRMincidentresolution> EntitlementtemplateIncidentResolutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_ServiceAppointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMserviceappointment> EntitlementtemplateServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateid_RelationShip")]
        [NotMapped] public IList<MicrosoftDynamicsCRMentitlement> EntitlementtemplateidRelationShip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_entitlementchannel_entitlementtemplateid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMentitlementtemplatechannel> EntitlementtemplateEntitlementchannelEntitlementtemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_entitlementtemplate_association")]
        [NotMapped] public IList<MicrosoftDynamicsCRMproduct> ProductEntitlementtemplateAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaid")]
        public MicrosoftDynamicsCRMsla Slaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_DuplicateMatchingRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementtemplateDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_DuplicateBaseRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementtemplateDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_OpportunityCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMopportunityclose> EntitlementtemplateOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_OrderCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMorderclose> EntitlementtemplateOrderCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_QuoteCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMquoteclose> EntitlementtemplateQuoteCloses { get; set; }

    }
}