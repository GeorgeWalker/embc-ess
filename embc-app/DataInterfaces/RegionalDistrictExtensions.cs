using Gov.Jag.Embc.Public.Models.Db;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gov.Jag.Embc.Public.DataInterfaces
{
    public static class RegionalDistrictExtensions
    {
        public static void AddRegionalDistrict(this EmbcDbContext context, RegionalDistrict RegionalDistrict)
        {
            // create a new RegionalDistrict.
            context.RegionalDistricts.Add(RegionalDistrict);
            context.SaveChanges();
        }

        public static void UpdateRegionalDistrict(this EmbcDbContext context, RegionalDistrict RegionalDistrict)
        {
            RegionalDistrict _RegionalDistrict = context.RegionalDistricts.FirstOrDefault<RegionalDistrict>(x => x.Id == RegionalDistrict.Id);
            _RegionalDistrict.Name = RegionalDistrict.Name;
            context.RegionalDistricts.Update(_RegionalDistrict);
            context.SaveChanges();
        }

        public static List<RegionalDistrict> GetRegionalDistricts(this EmbcDbContext context)
        {
            List<RegionalDistrict> RegionalDistricts =
                context.RegionalDistricts.ToList<RegionalDistrict>();
            return RegionalDistricts;
        }

        /// <summary>
        /// Returns a specific RegionalDistrict
        /// </summary>
        /// <param name="name">The name of the RegionalDistrict</param>
        /// <returns>The RegionalDistrict, or null if it does not exist.</returns>
        public static RegionalDistrict GetRegionalDistrictByName(this EmbcDbContext context, string name)
        {
            RegionalDistrict RegionalDistrict = context.RegionalDistricts.FirstOrDefault(x => x.Name == name);
            return RegionalDistrict;
        }

        /// <summary>
        /// Create RegionalDistricts from a (json) file
        /// </summary>
        /// <param name="context"></param>
        /// <param name="RegionalDistrictJsonPath"></param>
        public static void AddInitialRegionalDistrictsFromFile(this EmbcDbContext context, string RegionalDistrictJsonPath)
        {
            if (!string.IsNullOrEmpty(RegionalDistrictJsonPath) && File.Exists(RegionalDistrictJsonPath))
            {
                string RegionalDistrictJson = File.ReadAllText(RegionalDistrictJsonPath);
                context.AddInitialRegionalDistricts(RegionalDistrictJson);
            }
        }

        private static void AddInitialRegionalDistricts(this EmbcDbContext context, string RegionalDistrictJson)
        {
            List<RegionalDistrict> RegionalDistricts = JsonConvert.DeserializeObject<List<RegionalDistrict>>(RegionalDistrictJson);

            if (RegionalDistricts != null)
            {
                context.AddInitialRegionalDistricts(RegionalDistricts);
            }
        }

        private static void AddInitialRegionalDistricts(this EmbcDbContext context, List<RegionalDistrict> RegionalDistricts)
        {
            RegionalDistricts.ForEach(context.AddInitialRegionalDistrict);
        }

        /// <summary>
        /// Adds a RegionalDistrict to the system, only if it does not exist.
        /// </summary>
        private static void AddInitialRegionalDistrict(this EmbcDbContext context, RegionalDistrict initialRegionalDistrict)
        {
            RegionalDistrict RegionalDistrict = context.GetRegionalDistrictByName(initialRegionalDistrict.Name);
            if (RegionalDistrict != null)
            {
                return;
            }

            var region = context.GetRegionByName(initialRegionalDistrict.Region.Name);

            RegionalDistrict = new RegionalDistrict
            ()
            {
                Id = initialRegionalDistrict.Id,
                Name = initialRegionalDistrict.Name,
                Active = true,
                Region = region
            };

            context.AddRegionalDistrict(RegionalDistrict);
        }

        /// <summary>
        /// Update RegionalDistrict
        /// </summary>
        /// <param name="context"></param>
        /// <param name="RegionalDistrictInfo"></param>
        public static void UpdateSeedRegionalDistrictInfo(this EmbcDbContext context, RegionalDistrict RegionalDistrictInfo)
        {
            RegionalDistrict RegionalDistrict = context.GetRegionalDistrictByName(RegionalDistrictInfo.Name);
            if (RegionalDistrict == null)
            {
                context.AddRegionalDistrict(RegionalDistrictInfo);
            }
            else
            {
                var region = context.GetRegionByName(RegionalDistrictInfo.Region.Name);

                RegionalDistrict.Name = RegionalDistrictInfo.Name;
                RegionalDistrict.Active = RegionalDistrictInfo.Active;
                RegionalDistrict.Region = region;
                context.UpdateRegionalDistrict(RegionalDistrict);
            }
        }
    }
}
