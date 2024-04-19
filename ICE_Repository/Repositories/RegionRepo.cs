using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICE_Repository.Repositories
{
    public class RegionRepo : IRegionRepo
    {
        private readonly DataContext context;

        public RegionRepo(DataContext data)
        {
            this.context = data;
        }

        public Regions Create(Regions region)
        {
            context.Regions.Add(region);
            context.SaveChanges();
            return region;
        }

        public List<Regions> GetAll()
        {
            return context.Regions.ToList();
        }

        public Regions UpdateById(int id, Regions updatedRegion)
        {
            var region = context.Regions.FirstOrDefault(r => r.RegionId == id);

            if (region != null)
            {
                region.RegionName = updatedRegion.RegionName;
                region.CountryId = updatedRegion.CountryId;

                context.SaveChanges();
            }

            return region;
        }

        public Regions DeleteById(int id)
        {
            var region = context.Regions.FirstOrDefault(r => r.RegionId == id);

            if (region != null)
            {
                context.Regions.Remove(region);
                context.SaveChanges();
            }

            return region;
        }
    }
}
