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
    /// AppModuleCollection
    /// </summary>
    public partial class MicrosoftDynamicsCRMAppModuleCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAppModuleCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMAppModuleCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAppModuleCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMAppModuleCollection(IList<MicrosoftDynamicsCRMAppModuleInfo> appModuleInfoCollection = default(IList<MicrosoftDynamicsCRMAppModuleInfo>))
        {
            AppModuleInfoCollection = appModuleInfoCollection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AppModuleInfoCollection")]
        [NotMapped] public IList<MicrosoftDynamicsCRMAppModuleInfo> AppModuleInfoCollection { get; set; }

    }
}