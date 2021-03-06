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
    /// dynamicpropertyinstance
    /// </summary>
    public partial class MicrosoftDynamicsCRMdynamicpropertyinstance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyinstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyinstance(string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string dynamicpropertyinstanceid = default(string), string _transactioncurrencyidValue = default(string), object valuedecimal = default(object), string valuestring = default(string), bool? validationstatus = default(bool?), int? importsequencenumber = default(int?), int? dmtimportstate = default(int?), string _owningteamValue = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), double? valuedouble = default(double?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), long? versionnumber = default(long?), int? valueinteger = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), string _regardingobjectidValue = default(string), string _dynamicpropertyidValue = default(string), string _owninguserValue = default(string), string _owningbusinessunitValue = default(string), object exchangerate = default(object), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> dynamicpropertyinstanceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> dynamicpropertyinstanceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> dynamicpropertyinstanceMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> dynamicpropertyinstanceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> dynamicpropertyinstancePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMdynamicproperty dynamicpropertyid = default(MicrosoftDynamicsCRMdynamicproperty), MicrosoftDynamicsCRMinvoicedetail regardingobjectidInvoicedetail = default(MicrosoftDynamicsCRMinvoicedetail), MicrosoftDynamicsCRMopportunityproduct regardingobjectidOpportunityproduct = default(MicrosoftDynamicsCRMopportunityproduct), MicrosoftDynamicsCRMquotedetail regardingobjectidQuotedetail = default(MicrosoftDynamicsCRMquotedetail), MicrosoftDynamicsCRMsalesorderdetail regardingobjectidSalesorderdetail = default(MicrosoftDynamicsCRMsalesorderdetail))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Dynamicpropertyinstanceid = dynamicpropertyinstanceid;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Valuedecimal = valuedecimal;
            Valuestring = valuestring;
            Validationstatus = validationstatus;
            Importsequencenumber = importsequencenumber;
            Dmtimportstate = dmtimportstate;
            this._owningteamValue = _owningteamValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Valuedouble = valuedouble;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Valueinteger = valueinteger;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._dynamicpropertyidValue = _dynamicpropertyidValue;
            this._owninguserValue = _owninguserValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Exchangerate = exchangerate;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            DynamicpropertyinstanceSyncErrors = dynamicpropertyinstanceSyncErrors;
            DynamicpropertyinstanceAsyncOperations = dynamicpropertyinstanceAsyncOperations;
            DynamicpropertyinstanceMailboxTrackingFolders = dynamicpropertyinstanceMailboxTrackingFolders;
            DynamicpropertyinstanceBulkDeleteFailures = dynamicpropertyinstanceBulkDeleteFailures;
            DynamicpropertyinstancePrincipalObjectAttributeAccesses = dynamicpropertyinstancePrincipalObjectAttributeAccesses;
            Transactioncurrencyid = transactioncurrencyid;
            Owninguser = owninguser;
            Dynamicpropertyid = dynamicpropertyid;
            RegardingobjectidInvoicedetail = regardingobjectidInvoicedetail;
            RegardingobjectidOpportunityproduct = regardingobjectidOpportunityproduct;
            RegardingobjectidQuotedetail = regardingobjectidQuotedetail;
            RegardingobjectidSalesorderdetail = regardingobjectidSalesorderdetail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstanceid")]
        public string Dynamicpropertyinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuedecimal")]
        [NotMapped] public object Valuedecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuestring")]
        public string Valuestring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validationstatus")]
        public bool? Validationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuedouble")]
        public double? Valuedouble { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valueinteger")]
        public int? Valueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_dynamicpropertyid_value")]
        public string _dynamicpropertyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        [NotMapped] public object Exchangerate { get; set; }

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
        [JsonProperty(PropertyName = "dynamicpropertyinstance_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> DynamicpropertyinstanceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> DynamicpropertyinstanceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> DynamicpropertyinstanceMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> DynamicpropertyinstanceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstance_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> DynamicpropertyinstancePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyid")]
        public MicrosoftDynamicsCRMdynamicproperty Dynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoicedetail")]
        public MicrosoftDynamicsCRMinvoicedetail RegardingobjectidInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunityproduct")]
        public MicrosoftDynamicsCRMopportunityproduct RegardingobjectidOpportunityproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quotedetail")]
        public MicrosoftDynamicsCRMquotedetail RegardingobjectidQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorderdetail")]
        public MicrosoftDynamicsCRMsalesorderdetail RegardingobjectidSalesorderdetail { get; set; }

    }
}
