using Information.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Information.Api.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataSource.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            ///this is a nullable example, if is null it won't look for properties or execute any method
            //CityDto c = null;
            //string algo;
            //if(id == 2)
            //{
            //    algo = c?.Name;
            //}
            //else
            //{
            //    algo = c.Name;

            //}

            return Ok(CitiesDataSource.Current.Cities.Where(x => x.Id == id));
        }
    }
}
