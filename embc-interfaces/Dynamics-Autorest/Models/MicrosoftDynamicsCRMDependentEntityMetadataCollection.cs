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
    /// DependentEntityMetadataCollection
    /// </summary>
    public partial class MicrosoftDynamicsCRMDependentEntityMetadataCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentEntityMetadataCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentEntityMetadataCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentEntityMetadataCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentEntityMetadataCollection(IList<MicrosoftDynamicsCRMDependentEntityMetadata> dependantEntities = default(IList<MicrosoftDynamicsCRMDependentEntityMetadata>))
        {
            DependantEntities = dependantEntities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DependantEntities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMDependentEntityMetadata> DependantEntities { get; set; }

    }
}