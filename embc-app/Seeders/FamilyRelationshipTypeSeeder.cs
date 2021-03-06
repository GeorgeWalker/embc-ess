using Gov.Jag.Embc.Public.DataInterfaces;
using Gov.Jag.Embc.Public.Models.Db;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;

namespace Gov.Embc.Public.Seeders
{
    public class FamilyRelationshipTypeSeeder : Seeder<EmbcDbContext>
    {
        private readonly string[] _profileTriggers = { AllProfiles };

        public FamilyRelationshipTypeSeeder(IConfiguration configuration, IHostingEnvironment env, ILoggerFactory loggerFactory)
            : base(configuration, env, loggerFactory)
        { }

        protected override IEnumerable<string> TriggerProfiles => _profileTriggers;

        protected override void Invoke(EmbcDbContext context)
        {
            UpdateEntities(context);
        }

        public override int InvokeOrder => 5;

        private void UpdateEntities(EmbcDbContext context)
        {
            List<FamilyRelationshipType> seedEntities = GetSeedFamilyRelationshipTypes();

            foreach (FamilyRelationshipType FamilyRelationshipType in seedEntities)
            {
                context.UpdateSeedFamilyRelationshipTypeInfo(FamilyRelationshipType);
            }

            AddInitialFamilyRelationshipTypes(context);
        }

        private void AddInitialFamilyRelationshipTypes(EmbcDbContext context)
        {
            string FamilyRelationshipTypeInitializationFilename = Configuration["FamilyRelationshipTypeInitializationFilename"];
            if (string.IsNullOrEmpty(FamilyRelationshipTypeInitializationFilename))
            {
                // default to sample data, which is stored in the "SeedData" directory.
                FamilyRelationshipTypeInitializationFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedData" + Path.DirectorySeparatorChar + "FamilyRelationshipTypes.json");
            }
            context.AddInitialFamilyRelationshipTypesFromFile(FamilyRelationshipTypeInitializationFilename);
        }

        private List<FamilyRelationshipType> GetSeedFamilyRelationshipTypes()
        {
            List<FamilyRelationshipType> entities = new List<FamilyRelationshipType>(GetDefaultFamilyRelationshipTypes());

            if (IsProductionEnvironment)
            {
                entities.AddRange(GetProdFamilyRelationshipTypes());
            }
            else
            {
                entities.AddRange(GetDevFamilyRelationshipTypes());
            }

            return entities;
        }

        /// <summary>
        /// Returns a list of users to be populated in all environments.
        /// </summary>
        private List<FamilyRelationshipType> GetDefaultFamilyRelationshipTypes()
        {
            return new List<FamilyRelationshipType>();
        }

        /// <summary>
        /// Returns a list of jurisdictions to be populated in the Development environment.
        /// </summary>
        private List<FamilyRelationshipType> GetDevFamilyRelationshipTypes()
        {
            return new List<FamilyRelationshipType>();
        }

        /// <summary>
        /// Returns a list of jurisdictions to be populated in the Test environment.
        /// </summary>
        private List<FamilyRelationshipType> GetTestFamilyRelationshipTypes()
        {
            return new List<FamilyRelationshipType>();
        }

        /// <summary>
        /// Returns a list of jurisdictions to be populated in the Production environment.
        /// </summary>
        private List<FamilyRelationshipType> GetProdFamilyRelationshipTypes()
        {
            return new List<FamilyRelationshipType>();
        }
    }
}
