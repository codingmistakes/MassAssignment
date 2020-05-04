namespace MassAssignment.Models
{
    public class User
    {
        public User()
        {
            Account = new Account();
        }

        public int ID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public Account Account { get; set; }
    }
}