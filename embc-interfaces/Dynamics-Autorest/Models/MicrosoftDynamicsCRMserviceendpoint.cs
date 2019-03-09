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
    /// serviceendpoint
    /// </summary>
    public partial class MicrosoftDynamicsCRMserviceendpoint
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceendpoint class.
        /// </summary>
        public MicrosoftDynamicsCRMserviceendpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceendpoint class.
        /// </summary>
        public MicrosoftDynamicsCRMserviceendpoint(string sastoken = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string solutionid = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? ismanaged = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), int? userclaim = default(int?), string name = default(string), string serviceendpointid = default(string), bool? issaskeyset = default(bool?), int? connectionmode = default(int?), string serviceendpointidunique = default(string), bool? issastokenset = default(bool?), string solutionnamespace = default(string), string saskey = default(string), int? namespaceformat = default(int?), string _createdbyValue = default(string), string introducedversion = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string namespaceaddress = default(string), int? authtype = default(int?), string _modifiedbyValue = default(string), int? componentstate = default(int?), string _modifiedonbehalfbyValue = default(string), int? contract = default(int?), string description = default(string), int? messageformat = default(int?), string _organizationidValue = default(string), string path = default(string), string saskeyname = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> serviceendpointSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Sastoken = sastoken;
            Overwritetime = overwritetime;
            Solutionid = solutionid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            Ismanaged = ismanaged;
            Iscustomizable = iscustomizable;
            Userclaim = userclaim;
            Name = name;
            Serviceendpointid = serviceendpointid;
            Issaskeyset = issaskeyset;
            Connectionmode = connectionmode;
            Serviceendpointidunique = serviceendpointidunique;
            Issastokenset = issastokenset;
            Solutionnamespace = solutionnamespace;
            Saskey = saskey;
            Namespaceformat = namespaceformat;
            this._createdbyValue = _createdbyValue;
            Introducedversion = introducedversion;
            Createdon = createdon;
            Namespaceaddress = namespaceaddress;
            Authtype = authtype;
            this._modifiedbyValue = _modifiedbyValue;
            Componentstate = componentstate;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Contract = contract;
            Description = description;
            Messageformat = messageformat;
            this._organizationidValue = _organizationidValue;
            Path = path;
            Saskeyname = saskeyname;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Organizationid = organizationid;
            ServiceendpointSdkmessageprocessingstep = serviceendpointSdkmessageprocessingstep;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sastoken")]
        public string Sastoken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userclaim")]
        public int? Userclaim { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceendpointid")]
        public string Serviceendpointid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issaskeyset")]
        public bool? Issaskeyset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionmode")]
        public int? Connectionmode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceendpointidunique")]
        public string Serviceendpointidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issastokenset")]
        public bool? Issastokenset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionnamespace")]
        public string Solutionnamespace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "saskey")]
        public string Saskey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaceformat")]
        public int? Namespaceformat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaceaddress")]
        public string Namespaceaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authtype")]
        public int? Authtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract")]
        public int? Contract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageformat")]
        public int? Messageformat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "saskeyname")]
        public string Saskeyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "serviceendpoint_sdkmessageprocessingstep")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> ServiceendpointSdkmessageprocessingstep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}