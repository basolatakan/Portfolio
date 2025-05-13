namespace Portfolio.Models.Interfaces
{
    public interface IInvestors
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public float Amount { get; set; }
        public string Adress { get; set; }
    }
}
