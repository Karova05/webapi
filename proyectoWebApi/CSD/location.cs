using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoWebApi.CSD
{
    public class location
    {

        public string calle { get; set; }

        public string ciudad { get; set; }

        public string country { get; set; }

        public string postcode { get; set; }

        public int coordenada { get; set; }

        public TimeZone timezone { get; set; }

    }
}