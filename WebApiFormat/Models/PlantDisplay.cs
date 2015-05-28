using System;

namespace WebApiFormat.Models
{
    public class PlantDisplay
    {
        public Guid PlantGuid { get; set; }
        public string Name { get; set; }
        public Guid LocationGuid { get; set; }
        public string Address1 { get; set; }  
        public string Address2 { get; set; }
        public string City { get; set; }    
        public string InternationalPostalCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public int LocationTypeId { get; set; }
        public string ShipToName { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCodeFiveDigit { get; set; }
    }
}
