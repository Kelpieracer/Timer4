using System.Collections.Generic;
using System.Linq;
using RCB.TypeScript.Infrastructure;
using RCB.TypeScript.Models;

namespace RCB.TypeScript.Services
{
    public class PersonService : ServiceBase
    {
        protected static List<User> PeopleList { get; }

        static PersonService()
        {
            PeopleList = new List<User>
            {
                new User(1, "Bill", "Gates"),
                new User(2, "Jeffrey", "Richter"),
                new User(3, "Dennis", "Ritchie"),
                new User(4, "Ken", "Thompson"),
                new User(5, "Steve", "Jobs"),
                new User(6, "Steve", "Ballmer"),
                new User(7, "Alan", "Turing")
            };
        }

        public virtual Result<List<User>> Search(string term = null)
        {
            if (!string.IsNullOrEmpty(term))
            {
                term = term.ToLower();
                term = term.Trim();

                var result = 
                    PeopleList
                    .Where(x =>
                        x.FirstName.ToLower().Contains(term) ||
                        x.LastName.ToLower().Contains(term)
                    )
                    .ToList();

                return Ok(result);
            }

            return Ok(PeopleList);
        }

        public virtual Result<int> Add(User model)
        {
            if(model == null)
                return Error<int>();
            if(string.IsNullOrEmpty(model.FirstName))
                return Error<int>("First name not defined.");
            if(string.IsNullOrEmpty(model.LastName))
                return Error<int>("Last name not defined.");

            TrimStrings(model);

            var personExists =
                PeopleList
                .Any(x =>
                    x.FirstName == model.FirstName &&
                    x.LastName == model.LastName
                    );
            if(personExists)
            {
                return Error<int>("Person with the same first name and last name already exists.");
            }

            var newId = PeopleList.Max(x => x?.UserId ?? 0) + 1;
            model.UserId = newId;

            PeopleList.Add(model);

            return Ok(model.UserId);
        }
        
        public virtual Result Update(User model)
        {
            if (model == null)
                return Error();
            if (model.UserId <= 0)
                return Error($"{model.UserId} <= 0.");
            var person = PeopleList.Where(x => x.UserId == model.UserId).FirstOrDefault();
            if (person == null)
                return Error($"Person with id = {model.UserId} not found.");

            TrimStrings(model);

            var personExists =
                PeopleList
                .Any(x =>
                    x.UserId != model.UserId &&
                    x.FirstName == model.FirstName &&
                    x.LastName == model.LastName
                    );
            if(personExists)
            {
                return Error("Person with the same first name and last name already exists.");
            }

            person.FirstName = model.FirstName;
            person.LastName = model.LastName;

            return Ok();
        }

        public virtual Result Delete(int id)
        {
            var unit = PeopleList.Where(x => x.UserId == id).FirstOrDefault();
            if (unit == null)
                return Error($"Can't find person with Id = {id}.");
            PeopleList.Remove(unit);
            return Ok();
        }
        
        private static void TrimStrings(User model)
        {
            model.FirstName = model.FirstName.Trim();
            model.LastName = model.LastName.Trim();
        }
    }
}
