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
    /// businessunitnewsarticle
    /// </summary>
    public partial class MicrosoftDynamicsCRMbusinessunitnewsarticle
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbusinessunitnewsarticle class.
        /// </summary>
        public MicrosoftDynamicsCRMbusinessunitnewsarticle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbusinessunitnewsarticle class.
        /// </summary>
        public MicrosoftDynamicsCRMbusinessunitnewsarticle(string newsarticle = default(string), string articleurl = default(string), string _organizationidValue = default(string), string businessunitnewsarticleid = default(string), string _modifiedbyValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? activeon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? activeuntil = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? articletypecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string articletitle = default(string), string _createdbyValue = default(string), bool? showonhomepage = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), IList<MicrosoftDynamicsCRMbulkdeletefailure> businessUnitNewsArticleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMasyncoperation> businessUnitNewsArticleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesssession> businessUnitNewsArticleProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Newsarticle = newsarticle;
            Articleurl = articleurl;
            this._organizationidValue = _organizationidValue;
            Businessunitnewsarticleid = businessunitnewsarticleid;
            this._modifiedbyValue = _modifiedbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Activeon = activeon;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Activeuntil = activeuntil;
            Importsequencenumber = importsequencenumber;
            Articletypecode = articletypecode;
            Overriddencreatedon = overriddencreatedon;
            Articletitle = articletitle;
            this._createdbyValue = _createdbyValue;
            Showonhomepage = showonhomepage;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            BusinessUnitNewsArticleBulkDeleteFailures = businessUnitNewsArticleBulkDeleteFailures;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Organizationid = organizationid;
            BusinessUnitNewsArticleAsyncOperations = businessUnitNewsArticleAsyncOperations;
            BusinessUnitNewsArticleProcessSessions = businessUnitNewsArticleProcessSessions;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "newsarticle")]
        public string Newsarticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "articleurl")]
        public string Articleurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitnewsarticleid")]
        public string Businessunitnewsarticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeon")]
        public System.DateTimeOffset? Activeon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeuntil")]
        public System.DateTimeOffset? Activeuntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "articletypecode")]
        public int? Articletypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "articletitle")]
        public string Articletitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "showonhomepage")]
        public bool? Showonhomepage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BusinessUnitNewsArticle_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> BusinessUnitNewsArticleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BusinessUnitNewsArticle_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> BusinessUnitNewsArticleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BusinessUnitNewsArticle_ProcessSessions")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> BusinessUnitNewsArticleProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}