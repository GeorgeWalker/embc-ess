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
    /// LabelQueryExpression
    /// </summary>
    public partial class MicrosoftDynamicsCRMLabelQueryExpression
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLabelQueryExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMLabelQueryExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLabelQueryExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMLabelQueryExpression(IList<int?> filterLanguages = default(IList<int?>), int? missingLabelBehavior = default(int?))
        {
            FilterLanguages = filterLanguages;
            MissingLabelBehavior = missingLabelBehavior;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FilterLanguages")]
        [NotMapped] public IList<int?> FilterLanguages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MissingLabelBehavior")]
        public int? MissingLabelBehavior { get; set; }

    }
}