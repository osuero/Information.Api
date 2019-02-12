using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Information.Api.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointOfInterested { get; set; }
        
        public int? NumberOfPointOfInterest { get { return PointOfInterest?.Count; } }


        //foreach city exist a list of point of Interest

        public ICollection<PointOfInterestDto> PointOfInterest { get; set; }
            //this work as a constructor to avoid empty values
            = new List<PointOfInterestDto>();

    }
}
