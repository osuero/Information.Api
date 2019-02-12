using Information.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Information.Api
{
    public class CitiesDataSource
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataSource Current = new CitiesDataSource();

        public CitiesDataSource()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {  Id = 1,   Name="Test 1", Description="", NumberOfPointOfInterested=1,
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Description = "this is a very nice place for childrens",
                            Id =1,
                            Name= "Light park"
                        }
                    }
                },
                new CityDto()
                {  Id = 2,   Name="Test 2", Description="", NumberOfPointOfInterested=1
                ,
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Description = "this is a very nice place for EveryBody",
                            Id =2,
                            Name= "Megacentro"
                        }
                    }
                },
                new CityDto()
                {  Id = 3,   Name="Test 3", Description="", NumberOfPointOfInterested=1,
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Description = "this is a very nice place for EveryBody",
                            Id =3,
                            Name= "Agora Mall"
                        }
                    }
                },
                new CityDto()
                {  Id = 4,   Name="Test 4", Description="", NumberOfPointOfInterested=1,
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Description = "this is a very nice place for EveryBody",
                            Id =3,
                            Name= "Sambil"
                        }
                    }
                }
            };
        }
    }
}
