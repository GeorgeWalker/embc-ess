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
    /// bookableresource
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookableresource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresource class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresource class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresource(string _createdonbehalfbyValue = default(string), string _calendaridValue = default(string), string _accountidValue = default(string), int? importsequencenumber = default(int?), string _owningteamValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), int? resourcetype = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string name = default(string), string _owningbusinessunitValue = default(string), string _useridValue = default(string), string _modifiedonbehalfbyValue = default(string), string traversedpath = default(string), int? statuscode = default(int?), string _transactioncurrencyidValue = default(string), string bookableresourceid = default(string), int? timezone = default(int?), string _owninguserValue = default(string), string _contactidValue = default(string), int? timezoneruleversionnumber = default(int?), int? statecode = default(int?), long? versionnumber = default(long?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string stageid = default(string), string _createdbyValue = default(string), string processid = default(string), string _owneridValue = default(string), object exchangerate = default(object), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> bookableResourceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourceDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourceDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bookableresourceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> bookableresourceMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> bookableresourceProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookableresourceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> bookableresourcePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMannotation> bookableresourceAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMaccount accountId = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMbookableresourcebooking> bookableresourceBookableresourcebookingResource = default(IList<MicrosoftDynamicsCRMbookableresourcebooking>), IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> bookableresourceBookableresourcecategoryassnResource = default(IList<MicrosoftDynamicsCRMbookableresourcecategoryassn>), IList<MicrosoftDynamicsCRMbookableresourcecharacteristic> bookableresourceBookableresourcecharacteristicResource = default(IList<MicrosoftDynamicsCRMbookableresourcecharacteristic>), IList<MicrosoftDynamicsCRMbookableresourcegroup> bookableresourceBookableresourcegroupChildResource = default(IList<MicrosoftDynamicsCRMbookableresourcegroup>), IList<MicrosoftDynamicsCRMbookableresourcegroup> bookableresourceBookableresourcegroupParentResource = default(IList<MicrosoftDynamicsCRMbookableresourcegroup>), MicrosoftDynamicsCRMcalendar calendarid = default(MicrosoftDynamicsCRMcalendar), MicrosoftDynamicsCRMcontact contactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser userId = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._calendaridValue = _calendaridValue;
            this._accountidValue = _accountidValue;
            Importsequencenumber = importsequencenumber;
            this._owningteamValue = _owningteamValue;
            Createdon = createdon;
            this._modifiedbyValue = _modifiedbyValue;
            Resourcetype = resourcetype;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            Name = name;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._useridValue = _useridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Traversedpath = traversedpath;
            Statuscode = statuscode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Bookableresourceid = bookableresourceid;
            Timezone = timezone;
            this._owninguserValue = _owninguserValue;
            this._contactidValue = _contactidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statecode = statecode;
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Stageid = stageid;
            this._createdbyValue = _createdbyValue;
            Processid = processid;
            this._owneridValue = _owneridValue;
            Exchangerate = exchangerate;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookableResourceSyncErrors = bookableResourceSyncErrors;
            BookableresourceDuplicateMatchingRecord = bookableresourceDuplicateMatchingRecord;
            BookableresourceDuplicateBaseRecord = bookableresourceDuplicateBaseRecord;
            BookableresourceAsyncOperations = bookableresourceAsyncOperations;
            BookableresourceMailboxTrackingFolders = bookableresourceMailboxTrackingFolders;
            BookableresourceProcessSession = bookableresourceProcessSession;
            BookableresourceBulkDeleteFailures = bookableresourceBulkDeleteFailures;
            BookableresourcePrincipalObjectAttributeAccesses = bookableresourcePrincipalObjectAttributeAccesses;
            BookableresourceAnnotations = bookableresourceAnnotations;
            AccountId = accountId;
            BookableresourceBookableresourcebookingResource = bookableresourceBookableresourcebookingResource;
            BookableresourceBookableresourcecategoryassnResource = bookableresourceBookableresourcecategoryassnResource;
            BookableresourceBookableresourcecharacteristicResource = bookableresourceBookableresourcecharacteristicResource;
            BookableresourceBookableresourcegroupChildResource = bookableresourceBookableresourcegroupChildResource;
            BookableresourceBookableresourcegroupParentResource = bookableresourceBookableresourcegroupParentResource;
            Calendarid = calendarid;
            ContactId = contactId;
            UserId = userId;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_calendarid_value")]
        public string _calendaridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcetype")]
        public int? Resourcetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_userid_value")]
        public string _useridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourceid")]
        public string Bookableresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

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
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        [NotMapped] public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "BookableResource_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> BookableResourceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_DuplicateMatchingRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourceDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_DuplicateBaseRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourceDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> BookableresourceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BookableresourceMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> BookableresourceProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookableresourceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BookableresourcePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_Annotations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> BookableresourceAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccountId")]
        public MicrosoftDynamicsCRMaccount AccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcebooking_Resource")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcebooking> BookableresourceBookableresourcebookingResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcecategoryassn_Resource")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> BookableresourceBookableresourcecategoryassnResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcecharacteristic_Resource")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcecharacteristic> BookableresourceBookableresourcecharacteristicResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcegroup_ChildResource")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcegroup> BookableresourceBookableresourcegroupChildResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcegroup_ParentResource")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcegroup> BookableresourceBookableresourcegroupParentResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public MicrosoftDynamicsCRMcalendar Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactId")]
        public MicrosoftDynamicsCRMcontact ContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public MicrosoftDynamicsCRMsystemuser UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}