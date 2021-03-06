﻿using Application.Cars.Queries.GetCarsList;
using Application.Locations.Queries.GetLocationsListById;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Cities.Queries.GetCitiesList
{
    public class CitiesListVm
    {
        public IList<CityDto> Cities { get; set; }

        public CarDto Car { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
