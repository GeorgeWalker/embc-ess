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
    /// invaliddependency
    /// </summary>
    public partial class MicrosoftDynamicsCRMinvaliddependency
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMinvaliddependency class.
        /// </summary>
        public MicrosoftDynamicsCRMinvaliddependency()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMinvaliddependency class.
        /// </summary>
        public MicrosoftDynamicsCRMinvaliddependency(int? existingcomponenttype = default(int?), bool? isexistingnoderequiredcomponent = default(bool?), int? missingcomponentlookuptype = default(int?), string invaliddependencyid = default(string), int? missingcomponenttype = default(int?), string missingcomponentinfo = default(string), int? existingdependencytype = default(int?), string missingcomponentid = default(string), string existingcomponentid = default(string))
        {
            Existingcomponenttype = existingcomponenttype;
            Isexistingnoderequiredcomponent = isexistingnoderequiredcomponent;
            Missingcomponentlookuptype = missingcomponentlookuptype;
            Invaliddependencyid = invaliddependencyid;
            Missingcomponenttype = missingcomponenttype;
            Missingcomponentinfo = missingcomponentinfo;
            Existingdependencytype = existingdependencytype;
            Missingcomponentid = missingcomponentid;
            Existingcomponentid = existingcomponentid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "existingcomponenttype")]
        public int? Existingcomponenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isexistingnoderequiredcomponent")]
        public bool? Isexistingnoderequiredcomponent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingcomponentlookuptype")]
        public int? Missingcomponentlookuptype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invaliddependencyid")]
        public string Invaliddependencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingcomponenttype")]
        public int? Missingcomponenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingcomponentinfo")]
        public string Missingcomponentinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "existingdependencytype")]
        public int? Existingdependencytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingcomponentid")]
        public string Missingcomponentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "existingcomponentid")]
        public string Existingcomponentid { get; set; }

    }
}