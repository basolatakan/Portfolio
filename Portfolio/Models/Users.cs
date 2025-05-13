using Microsoft.AspNetCore.Mvc;
using Portfolio.Models.ModelMatedataTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    [ModelMetadataType(typeof(UsersMetadata))]
    public class Users
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string IdNumber { get; set; }
    }
}


