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
    /// GetValidManyToManyResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMGetValidManyToManyResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMGetValidManyToManyResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMGetValidManyToManyResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMGetValidManyToManyResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMGetValidManyToManyResponse(IList<string> entityNames = default(IList<string>))
        {
            EntityNames = entityNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityNames")]
        [NotMapped] public IList<string> EntityNames { get; set; }

    }
}