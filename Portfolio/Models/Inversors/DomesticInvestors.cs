using Portfolio.Models.Interfaces;
using Portfolio.Models.ModelMatedataTypes;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models.Inversors
{
    [MetadataType(typeof(DomesticInvestorMetadatType))]
    public class DomesticInvestors : IInvestors
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public float Amount { get; set; }
        public string Adress { get; set; }
        public string IdNumber { get; set; }    //farklı olan 

        public DomesticInvestors(){ }
        public DomesticInvestors(string _firstname, string _lastName, string _email, string _phone, float _amount, string _adress, string _idNumber) {
            FirstName = _firstname;
            LastName = _lastName;
            Email = _email;
            Phone = _phone;
            Amount = _amount;
            Adress = _adress;
            IdNumber = _idNumber;
        }
    }
}
