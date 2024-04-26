using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace proyectoWebApi.CSD
{
    public class usuario
    {

        public string gender { get; set; }    
        public nombre name { get; set; }

        public string location { get; set; }

        public string email { get; set; }

        public login login { get; set; }

        public DateTime fechanacim { get; set; }

        public string registered { get; set; }

        public string phone { get; set; }

        public string cell { get; set; }

        public int id { get; set; }

        public fotografia picture { get; set; }

        public string nat { get; set; }

    }
}