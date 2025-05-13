using Portfolio.Models.Interfaces;
using Portfolio.Models.ModelMatedataTypes;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models.Inversors
{
    [MetadataType(typeof(ForeignInvestorMetadataType))]
    public class ForeignInvestors : IInvestors
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public float Amount { get; set; }
        public string Adress { get; set; }
        public string PassportNumber { get; set; }  //farklı olan 

        public ForeignInvestors(string _firstname, string _lastName, string _email, string _phone, float _amount, string _adress, string _passportNumber)
        {
            FirstName = _firstname;
            LastName = _lastName;
            Email = _email;
            Phone = _phone;
            Amount = _amount;
            Adress = _adress;
            PassportNumber = _passportNumber;
        }
    }
}
