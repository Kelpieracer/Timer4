using System.Collections.Generic;
using System.Linq;
using RCB.TypeScript.Infrastructure;
using RCB.TypeScript.Models;

namespace RCB.TypeScript.Services
{
    public class UserService : ServiceBase
    {
        static UserService()
        {
        }

        public virtual Result<List<User>> Search(string term = null)
        {
            if (!string.IsNullOrEmpty(term))
            {
                List<User> result;
                using (var context = new TimerDbContext())
                {
                    term = term.ToLower();
                    term = term.Trim();

                    result =
                       context.Users.Where(x =>
                           x.FirstName.ToLower().Contains(term) ||
                           x.LastName.ToLower().Contains(term)
                       )
                       .ToList();
                }

                return Ok(result);
            }
            return Ok(new List<User>());
        }

        public virtual Result<int> Add(User model)
        {
            if (model == null)
                return Error<int>();
            if (string.IsNullOrEmpty(model.FirstName))
                return Error<int>("First name not defined.");
            if (string.IsNullOrEmpty(model.LastName))
                return Error<int>("Last name not defined.");

            TrimStrings(model);

            using (var context = new TimerDbContext())
            {
                var userExists =
                context.Users.Any(x =>
                    x.FirstName == model.FirstName &&
                    x.LastName == model.LastName
                    );

                if (userExists)
                {
                    return Error<int>("User with the same first name and last name already exists.");
                }

                //var newId = PeopleList.Max(x => x?.UserId ?? 0) + 1;
                //model.UserId = newId;

                context.Users.Add(model);
                context.SaveChanges();
                model = context.Users.FirstOrDefault(e => e.FirstName == model.FirstName && e.LastName == model.LastName);
            }

            return Ok(model.UserId);
        }

        public virtual Result Update(User model)
        {
            if (model == null)
                return Error();
            TrimStrings(model);
            using (var context = new TimerDbContext())
            {
                var userRecord = context.Users.FirstOrDefault(
                    e => e.UserId != model.UserId && e.FirstName == model.FirstName && e.LastName == model.LastName
                    );
                if (userRecord == null)
                    return Error($"User {model.FirstName} {model.LastName} not found.");

                userRecord.FirstName = model.FirstName;
                userRecord.LastName = model.LastName;

                context.SaveChanges();
            }
            return Ok();
        }

        public virtual Result Delete(int id)
        {
            using (var context = new TimerDbContext())
            {
                var record = context.Users.Where(x => x.UserId == id).FirstOrDefault();
                if (record == null)
                    return Error($"Can't find User with Id = {id}.");
                context.Users.Remove(record);
                context.SaveChanges();
            }
            return Ok();
        }

        private static void TrimStrings(User model)
        {
            model.FirstName = model.FirstName.Trim();
            model.LastName = model.LastName.Trim();
        }
    }
}
