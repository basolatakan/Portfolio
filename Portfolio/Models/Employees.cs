namespace Portfolio.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Employees(int id, string firstname, string lastname, int age, string address) 
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Address = address;
        }
    }
}
