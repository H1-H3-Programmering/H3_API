using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICE_Repository.Repositories
{
    public class CountryRepo : ICountryRepo
    {
        private readonly DataContext context;

        public CountryRepo(DataContext data)
        {
            this.context = data;
        }

        public Country Create(Country country)
        {
            context.Countries.Add(country);
            context.SaveChanges();
            return country;
        }

        public List<Country> GetAll()
        {
            return context.Countries.ToList();
        }

        public Country UpdateById(int id, Country updatedCountry)
        {
            var country = context.Countries.FirstOrDefault(c => c.CountryId == id);

            if (country != null)
            {
                country.CountryName = updatedCountry.CountryName;
                country.Continent = updatedCountry.Continent;
                country.Region = updatedCountry.Region;
                country.Language = updatedCountry.Language;
                country.Kitchen = updatedCountry.Kitchen;

                context.SaveChanges();
            }

            return country;
        }

        public Country DeleteById(int id)
        {
            var country = context.Countries.FirstOrDefault(c => c.CountryId == id);

            if (country != null)
            {
                context.Countries.Remove(country);
                context.SaveChanges();
            }

            return country;
        }
    }
}
