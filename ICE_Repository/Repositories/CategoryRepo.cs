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
    public class CategoryRepo : ICategoryRepo
    {
        private readonly DataContext context;
        public CategoryRepo(DataContext data)
        {
            this.context = data;
        }

        public Category Create(Category column)
        {
            // Context is our Database
            context.Categories.Add(column);
            context.SaveChanges();
            return column;
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public Category UpdateById(int id, Category updatedColumn)
        {
            var column = context.Categories.FirstOrDefault(c => c.CategoryId == id);

            if (column != null)
            {
                column.Name = updatedColumn.Name;

                context.SaveChanges();
            }

            return column;
        }

        public Category DeleteById(int id)
        {
            var column = context.Categories.FirstOrDefault(c => c.CategoryId == id);

            if (column != null)
            {
                context.Categories.Remove(column);
                context.SaveChanges();
            }
            return column;
        }
    }
}
