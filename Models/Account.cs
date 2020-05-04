namespace MassAssignment.Models
{
    public class Account
    {
        public Account()
        {
            ID = 99465;
            Title = "Main Account";
            Amount = 0.0;
            Description = "The default account created";
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public int UserID { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}