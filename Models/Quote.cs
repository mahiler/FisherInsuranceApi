using System; 

namespace FisherInsurance.Models 
{ 
    public class Quotes
    { 
        public int Id { get; set; } 
        public string Product { get; set; } 
        public DateTime ExpireDate { get; set; } 
        public decimal Price { get; set; } 
    } 
}