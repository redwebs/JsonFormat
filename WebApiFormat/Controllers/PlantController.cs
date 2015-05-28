using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApiFormat.Models;

namespace WebApiFormat.Controllers
{
    public class PlantController : ApiController
    {
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("api/Plant")]
        public IHttpActionResult Get()
        {
            try
            {
                var plant1 = new PlantDisplay
                {
                    Address1 = "1949 Ralson Road",
                    Address2 = "Suite 3",
                    City = "Washington",
                    CustomerName = "Super Buildings",
                    InternationalPostalCode = "EFKOE-23233",
                    Country = "United States",
                    LocationGuid = new Guid(),
                    Name = "Some Plant",
                    PlantGuid = new Guid(),
                    ShipToName = "Some Familar Name",
                    State = "MI",
                    ZipCodeFiveDigit = 54321,
                    LocationTypeId = 7,
                    CustomerId = "emu63114"
                };

                var plant2 = new PlantDisplay
                {
                    Address1 = "2210 Windsor Road",
                    Address2 = "Bldg B",
                    City = "Augusta",
                    CustomerName = "Steel Erectors",
                    InternationalPostalCode = "3FdOE-23233",
                    Country = "United States",
                    LocationGuid = new Guid(),
                    Name = "Some Erector Plant",
                    PlantGuid = new Guid(),
                    ShipToName = "Another Familar Name",
                    State = "GA",
                    ZipCodeFiveDigit = 30906,
                    LocationTypeId = 7,
                    CustomerId = "zxd90124"
                };

                var plants = new List<PlantDisplay>
                {
                    plant1,
                    plant2
                };

                return Ok(plants);
            }
            catch (Exception ex)
            {
                //Logger.ErrorException(string.Format("Error retrieving api/Menu: {0}", ex.Message), ex);
                return InternalServerError(ex);
            }
        }
    }
}
