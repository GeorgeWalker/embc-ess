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
    /// invoice
    /// </summary>
    public partial class MicrosoftDynamicsCRMinvoice
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoice
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoice
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoice(int? utcconversiontimezonecode = default(int?), object exchangerate = default(object), string shiptoName = default(string), string _contactidValue = default(string), int? importsequencenumber = default(int?), int? statuscode = default(int?), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), object totalamountBase = default(object), int? onholdtime = default(int?), string _owningbusinessunitValue = default(string), bool? ispricelocked = default(bool?), object freightamountBase = default(object), int? pricingerrorcode = default(int?), object discountpercentage = default(object), string _owninguserValue = default(string), object totaldiscountamountBase = default(object), string description = default(string), object freightamount = default(object), string billtoLine2 = default(string), object totaltaxBase = default(object), string shiptoLine2 = default(string), object totallineitemdiscountamount = default(object), long? versionnumber = default(long?), string invoicenumber = default(string), string _modifiedonbehalfbyValue = default(string), string traversedpath = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statecode = default(int?), string billtoPostalcode = default(string), object totalamount = default(object), string shiptoStateorprovince = default(string), string entityimageid = default(string), string shiptoLine1 = default(string), object totallineitemamountBase = default(object), object discountamountBase = default(object), object totallineitemdiscountamountBase = default(object), string shiptoPostalcode = default(string), string _accountidValue = default(string), string shiptoTelephone = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string shiptoComposite = default(string), string _transactioncurrencyidValue = default(string), string billtoTelephone = default(string), string name = default(string), string entityimageUrl = default(string), string shiptoCountry = default(string), int? prioritycode = default(int?), long? entityimageTimestamp = default(long?), string _salesorderidValue = default(string), int? timezoneruleversionnumber = default(int?), object totalamountlessfreight = default(object), string emailaddress = default(string), string _slaidValue = default(string), bool? willcall = default(bool?), string shiptoCity = default(string), string processid = default(string), string _pricelevelidValue = default(string), string stageid = default(string), string billtoLine3 = default(string), string shiptoLine3 = default(string), object totaldiscountamount = default(object), string shiptoFax = default(string), int? paymenttermscode = default(int?), string billtoLine1 = default(string), string _owneridValue = default(string), string _slainvokedidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string billtoFax = default(string), string billtoCity = default(string), string _createdonbehalfbyValue = default(string), string billtoComposite = default(string), string _modifiedbyValue = default(string), string invoiceid = default(string), object totallineitemamount = default(object), string billtoCountry = default(string), string _opportunityidValue = default(string), System.DateTimeOffset? datedelivered = default(System.DateTimeOffset?), object discountamount = default(object), string billtoName = default(string), string billtoStateorprovince = default(string), object entityimage = default(object), System.DateTimeOffset? lastbackofficesubmit = default(System.DateTimeOffset?), string _owningteamValue = default(string), int? shiptoFreighttermscode = default(int?), int? shippingmethodcode = default(int?), string _customeridValue = default(string), string _createdbyValue = default(string), object totalamountlessfreightBase = default(object), object totaltax = default(object), System.DateTimeOffset? duedate = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> invoiceActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> invoiceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> invoiceActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMasyncoperation> invoiceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> invoiceMailboxTrackingFolder = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> invoiceProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> invoiceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> invoicePrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMappointment> invoiceAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> invoiceEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> invoiceFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> invoiceLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> invoicePhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> invoiceTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> invoiceRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> invoiceSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMconnection> invoiceConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> invoiceConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> invoiceAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> invoiceServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMcontact> contactinvoicesAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMinvoicedetail> invoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceInvoice = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), MicrosoftDynamicsCRMsalesorder salesorderid = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMsla slainvokedidInvoiceSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsla slaInvoiceSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMmsdynPlaybookinstance> msdynPlaybookinstanceInvoice = default(IList<MicrosoftDynamicsCRMmsdynPlaybookinstance>))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Exchangerate = exchangerate;
            ShiptoName = shiptoName;
            this._contactidValue = _contactidValue;
            Importsequencenumber = importsequencenumber;
            Statuscode = statuscode;
            Lastonholdtime = lastonholdtime;
            TotalamountBase = totalamountBase;
            Onholdtime = onholdtime;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Ispricelocked = ispricelocked;
            FreightamountBase = freightamountBase;
            Pricingerrorcode = pricingerrorcode;
            Discountpercentage = discountpercentage;
            this._owninguserValue = _owninguserValue;
            TotaldiscountamountBase = totaldiscountamountBase;
            Description = description;
            Freightamount = freightamount;
            BilltoLine2 = billtoLine2;
            TotaltaxBase = totaltaxBase;
            ShiptoLine2 = shiptoLine2;
            Totallineitemdiscountamount = totallineitemdiscountamount;
            Versionnumber = versionnumber;
            Invoicenumber = invoicenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Traversedpath = traversedpath;
            Createdon = createdon;
            Statecode = statecode;
            BilltoPostalcode = billtoPostalcode;
            Totalamount = totalamount;
            ShiptoStateorprovince = shiptoStateorprovince;
            Entityimageid = entityimageid;
            ShiptoLine1 = shiptoLine1;
            TotallineitemamountBase = totallineitemamountBase;
            DiscountamountBase = discountamountBase;
            TotallineitemdiscountamountBase = totallineitemdiscountamountBase;
            ShiptoPostalcode = shiptoPostalcode;
            this._accountidValue = _accountidValue;
            ShiptoTelephone = shiptoTelephone;
            Modifiedon = modifiedon;
            ShiptoComposite = shiptoComposite;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            BilltoTelephone = billtoTelephone;
            Name = name;
            EntityimageUrl = entityimageUrl;
            ShiptoCountry = shiptoCountry;
            Prioritycode = prioritycode;
            EntityimageTimestamp = entityimageTimestamp;
            this._salesorderidValue = _salesorderidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Totalamountlessfreight = totalamountlessfreight;
            Emailaddress = emailaddress;
            this._slaidValue = _slaidValue;
            Willcall = willcall;
            ShiptoCity = shiptoCity;
            Processid = processid;
            this._pricelevelidValue = _pricelevelidValue;
            Stageid = stageid;
            BilltoLine3 = billtoLine3;
            ShiptoLine3 = shiptoLine3;
            Totaldiscountamount = totaldiscountamount;
            ShiptoFax = shiptoFax;
            Paymenttermscode = paymenttermscode;
            BilltoLine1 = billtoLine1;
            this._owneridValue = _owneridValue;
            this._slainvokedidValue = _slainvokedidValue;
            Overriddencreatedon = overriddencreatedon;
            BilltoFax = billtoFax;
            BilltoCity = billtoCity;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            BilltoComposite = billtoComposite;
            this._modifiedbyValue = _modifiedbyValue;
            Invoiceid = invoiceid;
            Totallineitemamount = totallineitemamount;
            BilltoCountry = billtoCountry;
            this._opportunityidValue = _opportunityidValue;
            Datedelivered = datedelivered;
            Discountamount = discountamount;
            BilltoName = billtoName;
            BilltoStateorprovince = billtoStateorprovince;
            Entityimage = entityimage;
            Lastbackofficesubmit = lastbackofficesubmit;
            this._owningteamValue = _owningteamValue;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            Shippingmethodcode = shippingmethodcode;
            this._customeridValue = _customeridValue;
            this._createdbyValue = _createdbyValue;
            TotalamountlessfreightBase = totalamountlessfreightBase;
            Totaltax = totaltax;
            Duedate = duedate;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            InvoiceActivityPointers = invoiceActivityPointers;
            InvoiceSyncErrors = invoiceSyncErrors;
            InvoiceActivityParties = invoiceActivityParties;
            InvoiceAsyncOperations = invoiceAsyncOperations;
            InvoiceMailboxTrackingFolder = invoiceMailboxTrackingFolder;
            InvoiceProcessSessions = invoiceProcessSessions;
            InvoiceBulkDeleteFailures = invoiceBulkDeleteFailures;
            InvoicePrincipalobjectattributeaccess = invoicePrincipalobjectattributeaccess;
            StageidProcessstage = stageidProcessstage;
            Transactioncurrencyid = transactioncurrencyid;
            InvoiceAppointments = invoiceAppointments;
            InvoiceEmails = invoiceEmails;
            InvoiceFaxes = invoiceFaxes;
            InvoiceLetters = invoiceLetters;
            InvoicePhonecalls = invoicePhonecalls;
            InvoiceTasks = invoiceTasks;
            InvoiceRecurringAppointmentMasters = invoiceRecurringAppointmentMasters;
            InvoiceSocialActivities = invoiceSocialActivities;
            InvoiceConnections1 = invoiceConnections1;
            InvoiceConnections2 = invoiceConnections2;
            InvoiceAnnotation = invoiceAnnotation;
            InvoiceServiceAppointments = invoiceServiceAppointments;
            CustomeridAccount = customeridAccount;
            ContactinvoicesAssociation = contactinvoicesAssociation;
            CustomeridContact = customeridContact;
            InvoiceDetails = invoiceDetails;
            SlakpiinstanceInvoice = slakpiinstanceInvoice;
            Opportunityid = opportunityid;
            Pricelevelid = pricelevelid;
            Salesorderid = salesorderid;
            SlainvokedidInvoiceSla = slainvokedidInvoiceSla;
            SlaInvoiceSla = slaInvoiceSla;
            MsdynPlaybookinstanceInvoice = msdynPlaybookinstanceInvoice;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        [NotMapped] public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastonholdtime")]
        public System.DateTimeOffset? Lastonholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount_base")]
        [NotMapped] public object TotalamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onholdtime")]
        public int? Onholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispricelocked")]
        public bool? Ispricelocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount_base")]
        [NotMapped] public object FreightamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        [NotMapped] public object Discountpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount_base")]
        [NotMapped] public object TotaldiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount")]
        [NotMapped] public object Freightamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line2")]
        public string BilltoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax_base")]
        [NotMapped] public object TotaltaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount")]
        [NotMapped] public object Totallineitemdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicenumber")]
        public string Invoicenumber { get; set; }

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
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_postalcode")]
        public string BilltoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount")]
        [NotMapped] public object Totalamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount_base")]
        [NotMapped] public object TotallineitemamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount_base")]
        [NotMapped] public object DiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount_base")]
        [NotMapped] public object TotallineitemdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_composite")]
        public string ShiptoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_telephone")]
        public string BilltoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prioritycode")]
        public int? Prioritycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesorderid_value")]
        public string _salesorderidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight")]
        [NotMapped] public object Totalamountlessfreight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line3")]
        public string BilltoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount")]
        [NotMapped] public object Totaldiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymenttermscode")]
        public int? Paymenttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line1")]
        public string BilltoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slainvokedid_value")]
        public string _slainvokedidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_fax")]
        public string BilltoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_city")]
        public string BilltoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_composite")]
        public string BilltoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceid")]
        public string Invoiceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount")]
        [NotMapped] public object Totallineitemamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_country")]
        public string BilltoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datedelivered")]
        public System.DateTimeOffset? Datedelivered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount")]
        [NotMapped] public object Discountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_name")]
        public string BilltoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_stateorprovince")]
        public string BilltoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        [NotMapped] public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastbackofficesubmit")]
        public System.DateTimeOffset? Lastbackofficesubmit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight_base")]
        [NotMapped] public object TotalamountlessfreightBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax")]
        [NotMapped] public object Totaltax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duedate")]
        public System.DateTimeOffset? Duedate { get; set; }

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
        [JsonProperty(PropertyName = "Invoice_ActivityPointers")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivitypointer> InvoiceActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> InvoiceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_activity_parties")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivityparty> InvoiceActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> InvoiceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_MailboxTrackingFolder")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> InvoiceMailboxTrackingFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_ProcessSessions")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> InvoiceProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> InvoiceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_principalobjectattributeaccess")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> InvoicePrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Appointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMappointment> InvoiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Emails")]
        [NotMapped] public IList<MicrosoftDynamicsCRMemail> InvoiceEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Faxes")]
        [NotMapped] public IList<MicrosoftDynamicsCRMfax> InvoiceFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Letters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMletter> InvoiceLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Phonecalls")]
        [NotMapped] public IList<MicrosoftDynamicsCRMphonecall> InvoicePhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Tasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMtask> InvoiceTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_RecurringAppointmentMasters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> InvoiceRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_SocialActivities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsocialactivity> InvoiceSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_connections1")]
        [NotMapped] public IList<MicrosoftDynamicsCRMconnection> InvoiceConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_connections2")]
        [NotMapped] public IList<MicrosoftDynamicsCRMconnection> InvoiceConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Annotation")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> InvoiceAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_ServiceAppointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMserviceappointment> InvoiceServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoices_association")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcontact> ContactinvoicesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_details")]
        [NotMapped] public IList<MicrosoftDynamicsCRMinvoicedetail> InvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_invoice")]
        [NotMapped] public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public MicrosoftDynamicsCRMsalesorder Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_invoice_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidInvoiceSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_invoice_sla")]
        public MicrosoftDynamicsCRMsla SlaInvoiceSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_invoice")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynPlaybookinstance> MsdynPlaybookinstanceInvoice { get; set; }

    }
}