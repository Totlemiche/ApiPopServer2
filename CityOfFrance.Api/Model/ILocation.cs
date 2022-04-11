using CityOfFrance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfFrance.Api.Model
{
    public interface ILocation
    {
        string Nom { get; set; }

        string Code { get; set; }

        string CodeDepartement { get; set; }

        string CodeRegion { get; set; }

        List<string> CodesPostaux { get; set; }

        int Population { get; set; }
    }
}

