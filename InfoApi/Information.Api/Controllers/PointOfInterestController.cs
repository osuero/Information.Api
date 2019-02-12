using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Information.Api.Controllers
{
    [Route("api/cities")]
    public class PointOfInterestController:Controller
    {

        [HttpGet("{cityId}/PointOfInterest/")]
        public IActionResult GetPointOfInterested(int cityId)
        {
           var city= CitiesDataSource.Current.Cities.FirstOrDefault(x => x.Id == cityId);
            if (city == null)
            {

                return NotFound();
            }

            return Ok(city.PointOfInterest);

        }

        [HttpGet("{cityId}/PointOfInterest/{Id}")]
        public IActionResult GetPointOfInterested(int cityId, int Id)
        {
            var city = CitiesDataSource.Current.Cities.FirstOrDefault(x => x.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            var pointOfinterest = city.PointOfInterest.FirstOrDefault(x => x.Id == Id);

            if (pointOfinterest == null)
            {
                return NotFound();
            }

            return Ok(pointOfinterest);
        }
    }
}
