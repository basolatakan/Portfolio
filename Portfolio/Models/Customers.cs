namespace Portfolio.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Customers(int id,string firstName, string lastName, int age, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
        }
    }
}
