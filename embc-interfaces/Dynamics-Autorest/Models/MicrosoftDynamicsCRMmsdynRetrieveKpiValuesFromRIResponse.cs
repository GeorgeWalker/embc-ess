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
    /// msdyn_RetrieveKpiValuesFromRIResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynRetrieveKpiValuesFromRIResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynRetrieveKpiValuesFromRIResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynRetrieveKpiValuesFromRIResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynRetrieveKpiValuesFromRIResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynRetrieveKpiValuesFromRIResponse(string kpiValues = default(string))
        {
            KpiValues = kpiValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KpiValues")]
        public string KpiValues { get; set; }

    }
}