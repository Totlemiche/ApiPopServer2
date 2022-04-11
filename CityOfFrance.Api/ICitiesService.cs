using CityOfFrance.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfFrance.Api
{
    public interface ICitiesService
    {
        /// <summary>
        /// Fonction permettant d'obtenir une liste de ville en fonction du code postal
        /// </summary>
        /// <param name="postalCode">Code postal de la ville</param>
        /// <returns>Liste de villes</returns>
        Task<List<ILocation>> GetLocationsAsync(string postalCode);
    }
}
