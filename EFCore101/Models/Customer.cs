using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore101.Models
{
    public class Customer
    {
#nullable enable
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string? Address {get; set;}
        public string? Phone {get; set;}
# nullable disable
        public ICollection<Order> Orders {get; set;}
    }
}