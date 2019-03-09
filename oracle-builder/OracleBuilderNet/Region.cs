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
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// gov_region
    /// </summary>
    public partial class Region
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }


        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regionid")]
        [Key]
        public Guid Regionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "region_incidentTasks")]
        public IList<IncidentTask> RegionIncidentTasks { get; set; }


        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "region_communities")]
        [NotMapped] public IList<Community> RegionCommunities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "region_facilities")]
        [NotMapped] public IList<Equipment> RegionFacilities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "region_registrations")]
        [NotMapped] public IList<Registration> RegionRegistrations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_EMBCRepresentativeId")]
        public Systemuser EMBCRepresentative { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryContact")]
        public Contact PrimaryContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_evacueeContacts")]
        [NotMapped] public IList<Contact> GovRegionEvacueeContacts { get; set; }

    }
}