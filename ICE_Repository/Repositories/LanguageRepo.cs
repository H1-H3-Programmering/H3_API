using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICE_Repository.Repositories
{
    public class LanguageRepo : ILanguageRepo
    {
        private readonly DataContext context;

        public LanguageRepo(DataContext data)
        {
            this.context = data;
        }

        public Language Create(Language language)
        {
            context.Languages.Add(language);
            context.SaveChanges();
            return language;
        }

        public List<Language> GetAll()
        {
            return context.Languages.ToList();
        }

        public Language UpdateById(int id, Language updatedLanguage)
        {
            var language = context.Languages.FirstOrDefault(l => l.LanguageId == id);

            if (language != null)
            {
                language.LanguageName = updatedLanguage.LanguageName;
                language.CountryId = updatedLanguage.CountryId;

                context.SaveChanges();
            }

            return language;
        }

        public Language DeleteById(int id)
        {
            var language = context.Languages.FirstOrDefault(l => l.LanguageId == id);

            if (language != null)
            {
                context.Languages.Remove(language);
                context.SaveChanges();
            }

            return language;
        }
    }
}
