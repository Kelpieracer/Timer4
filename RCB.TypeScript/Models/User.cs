namespace RCB.TypeScript.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(int id, string firstName, string lastName)
        {
            UserId = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public User()
        {

        }
    }
}
