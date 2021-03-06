using System;

namespace Gov.Jag.Embc.Public.DataInterfaces
{
    public static partial class ViewModelConversions
    {
        public static ViewModels.RegionalDistrict ToViewModel(this Models.Db.RegionalDistrict source)
        {
            ViewModels.RegionalDistrict result = null;
            if (source != null)
            {
                result = new ViewModels.RegionalDistrict()
                {
                    Id = source.Id.ToString(),
                    Name = source.Name,
                    Active = source.Active,
                    Region = source.Region.ToViewModel()
                };
            }
            return result;
        }

        public static Models.Db.RegionalDistrict ToModel(this ViewModels.RegionalDistrict source)
        {
            Models.Db.RegionalDistrict result = null;
            if (source != null)
            {
                result = new Models.Db.RegionalDistrict()
                {
                    Name = source.Name,
                    Active = source.Active,
                    Region = source.Region.ToModel()
                };
                if (source.Id != null)
                {
                    result.Id = Guid.Parse(source.Id);
                }
            }
            return result;
        }
    }
}
