// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// msdyn_callablecontext_msdyn_playbooktemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynCallablecontextMsdynPlaybooktemplate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynCallablecontextMsdynPlaybooktemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynCallablecontextMsdynPlaybooktemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynCallablecontextMsdynPlaybooktemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynCallablecontextMsdynPlaybooktemplate(string msdynPlaybooktemplateid = default(string), string msdynCallablecontextid = default(string), long? versionnumber = default(long?), string msdynCallablecontextMsdynPlaybooktemplateid = default(string))
        {
            MsdynPlaybooktemplateid = msdynPlaybooktemplateid;
            MsdynCallablecontextid = msdynCallablecontextid;
            Versionnumber = versionnumber;
            MsdynCallablecontextMsdynPlaybooktemplateid = msdynCallablecontextMsdynPlaybooktemplateid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbooktemplateid")]
        public string MsdynPlaybooktemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_callablecontextid")]
        public string MsdynCallablecontextid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_callablecontext_msdyn_playbooktemplateid")]
        public string MsdynCallablecontextMsdynPlaybooktemplateid { get; set; }

    }
}