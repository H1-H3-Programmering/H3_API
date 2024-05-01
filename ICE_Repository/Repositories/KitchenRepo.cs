using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Repositories
{
    public class KitchenRepo : IKitchenRepo
    {
        private readonly DataContext context;
        public KitchenRepo(DataContext data)
        {
            this.context = data;
        }

        public Kitchen Create(Kitchen column)
        {
            // Context is our Database
            context.Kitchens.Add(column);
            context.SaveChanges();
            return column;
        }

        public List<Kitchen> GetAll()
        {
            return context.Kitchens.ToList();
        }

        public Kitchen UpdateById(int id, Kitchen updatedColumn)
        {
            var column = context.Kitchens.FirstOrDefault(c => c.KitchenId == id);

            if (column != null)
            {
                column.Name = updatedColumn.Name;
                column.Continent = updatedColumn.Continent;
                column.Region = updatedColumn.Region;
                column.CountryId = updatedColumn.CountryId;
                column.RecipeId = updatedColumn.RecipeId;

                context.SaveChanges();
            }

            return column;
        }

        public Kitchen DeleteById(int id)
        {
            var column = context.Kitchens.FirstOrDefault(c => c.KitchenId == id);

            if (column != null)
            {
                context.Kitchens.Remove(column);
                context.SaveChanges();
            }
            return column;
        }
    }
}
