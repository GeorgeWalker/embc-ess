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
    /// gov_community
    /// </summary>
    public partial class MicrosoftDynamicsCRMgovCommunity
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMgovCommunity
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMgovCommunity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMgovCommunity
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMgovCommunity(string _owneridValue = default(string), string govCountry = default(string), string govCommunityid = default(string), string _owningbusinessunitValue = default(string), string _modifiedbyValue = default(string), string govStreet = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string govStateorprovince = default(string), string _modifiedonbehalfbyValue = default(string), string govCity = default(string), int? timezoneruleversionnumber = default(int?), int? statuscode = default(int?), string govAlternatephone = default(string), string _govRegionidValue = default(string), int? statecode = default(int?), string govTelephone = default(string), string govEmail = default(string), string govName = default(string), string emailaddress = default(string), long? versionnumber = default(long?), string _owninguserValue = default(string), int? utcconversiontimezonecode = default(int?), string govPostalcode = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _govPrimarycontactidValue = default(string), int? importsequencenumber = default(int?), string _createdbyValue = default(string), string _owningteamValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string govPhone = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> govCommunityActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> govCommunitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> govCommunityActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> govCommunityDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> govCommunityDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> govCommunityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> govCommunityMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> govCommunityProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> govCommunityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> govCommunityPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> govCommunityAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> govCommunityEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> govCommunityFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> govCommunityLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> govCommunityPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> govCommunityTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> govCommunityRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> govCommunitySocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMannotation> govCommunityAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> govCommunityServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMequipment> govCommunityFacilities = default(IList<MicrosoftDynamicsCRMequipment>), IList<MicrosoftDynamicsCRMgovIncidenttask> govCommunityIncidenttasks = default(IList<MicrosoftDynamicsCRMgovIncidenttask>), IList<MicrosoftDynamicsCRMgovRegistration> govCommunityRegistrations = default(IList<MicrosoftDynamicsCRMgovRegistration>), MicrosoftDynamicsCRMgovRegion govRegionId = default(MicrosoftDynamicsCRMgovRegion), MicrosoftDynamicsCRMcontact govPrimaryContactId = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMcontact> govCommunityEvacueecontacts = default(IList<MicrosoftDynamicsCRMcontact>))
        {
            this._owneridValue = _owneridValue;
            GovCountry = govCountry;
            GovCommunityid = govCommunityid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            GovStreet = govStreet;
            Modifiedon = modifiedon;
            GovStateorprovince = govStateorprovince;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            GovCity = govCity;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statuscode = statuscode;
            GovAlternatephone = govAlternatephone;
            this._govRegionidValue = _govRegionidValue;
            Statecode = statecode;
            GovTelephone = govTelephone;
            GovEmail = govEmail;
            GovName = govName;
            Emailaddress = emailaddress;
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            GovPostalcode = govPostalcode;
            Createdon = createdon;
            this._govPrimarycontactidValue = _govPrimarycontactidValue;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            GovPhone = govPhone;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            GovCommunityActivityPointers = govCommunityActivityPointers;
            GovCommunitySyncErrors = govCommunitySyncErrors;
            GovCommunityActivityParties = govCommunityActivityParties;
            GovCommunityDuplicateMatchingRecord = govCommunityDuplicateMatchingRecord;
            GovCommunityDuplicateBaseRecord = govCommunityDuplicateBaseRecord;
            GovCommunityAsyncOperations = govCommunityAsyncOperations;
            GovCommunityMailboxTrackingFolders = govCommunityMailboxTrackingFolders;
            GovCommunityProcessSession = govCommunityProcessSession;
            GovCommunityBulkDeleteFailures = govCommunityBulkDeleteFailures;
            GovCommunityPrincipalObjectAttributeAccesses = govCommunityPrincipalObjectAttributeAccesses;
            GovCommunityAppointments = govCommunityAppointments;
            GovCommunityEmails = govCommunityEmails;
            GovCommunityFaxes = govCommunityFaxes;
            GovCommunityLetters = govCommunityLetters;
            GovCommunityPhoneCalls = govCommunityPhoneCalls;
            GovCommunityTasks = govCommunityTasks;
            GovCommunityRecurringAppointmentMasters = govCommunityRecurringAppointmentMasters;
            GovCommunitySocialActivities = govCommunitySocialActivities;
            GovCommunityAnnotations = govCommunityAnnotations;
            GovCommunityServiceAppointments = govCommunityServiceAppointments;
            GovCommunityFacilities = govCommunityFacilities;
            GovCommunityIncidenttasks = govCommunityIncidenttasks;
            GovCommunityRegistrations = govCommunityRegistrations;
            GovRegionId = govRegionId;
            GovPrimaryContactId = govPrimaryContactId;
            GovCommunityEvacueecontacts = govCommunityEvacueecontacts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_country")]
        public string GovCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_communityid")]
        public string GovCommunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_street")]
        public string GovStreet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_stateorprovince")]
        public string GovStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_city")]
        public string GovCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_alternatephone")]
        public string GovAlternatephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_gov_regionid_value")]
        public string _govRegionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_telephone")]
        public string GovTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_email")]
        public string GovEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_name")]
        public string GovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_postalcode")]
        public string GovPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_gov_primarycontactid_value")]
        public string _govPrimarycontactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_phone")]
        public string GovPhone { get; set; }

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
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_ActivityPointers")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivitypointer> GovCommunityActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> GovCommunitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_ActivityParties")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivityparty> GovCommunityActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_DuplicateMatchingRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> GovCommunityDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_DuplicateBaseRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> GovCommunityDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> GovCommunityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> GovCommunityMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> GovCommunityProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> GovCommunityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> GovCommunityPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_Appointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMappointment> GovCommunityAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_Emails")]
        [NotMapped] public IList<MicrosoftDynamicsCRMemail> GovCommunityEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_Faxes")]
        [NotMapped] public IList<MicrosoftDynamicsCRMfax> GovCommunityFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_Letters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMletter> GovCommunityLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_PhoneCalls")]
        [NotMapped] public IList<MicrosoftDynamicsCRMphonecall> GovCommunityPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_Tasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMtask> GovCommunityTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_RecurringAppointmentMasters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> GovCommunityRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_SocialActivities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsocialactivity> GovCommunitySocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_Annotations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> GovCommunityAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_ServiceAppointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMserviceappointment> GovCommunityServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_facilities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMequipment> GovCommunityFacilities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_incidenttasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovIncidenttask> GovCommunityIncidenttasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_registrations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovRegistration> GovCommunityRegistrations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_RegionId")]
        public MicrosoftDynamicsCRMgovRegion GovRegionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_PrimaryContactId")]
        public MicrosoftDynamicsCRMcontact GovPrimaryContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_community_evacueecontacts")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcontact> GovCommunityEvacueecontacts { get; set; }

    }
}