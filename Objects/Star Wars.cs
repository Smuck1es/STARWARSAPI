using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsAPI
{
    internal class StarWars
    {
        public string Films { get; set; }
        public string People { get; set; }
        public string Planets { get; set; }
        public string Species { get; set; }
        public string Starships { get; set; }
        public string Vehicles { get; set; }

        public StarWars() { }

        public void SetFilms(string films) => Films = films;
        public void SetPeople(string people) => People = people;
        public void SetPlanets(string planets) => Planets = planets;
        public void SetSpecies(string species) => Species = species;
        public void SetStarships(string starships) => Starships = starships;
        public void SetVehicles(string vehicles) => Vehicles = vehicles;

        // Method to initialize the star wars information
        public void StarWarsInformation()
        {
            SetFilms("https://swapi.dev/api/films/");
            SetPeople("https://swapi.dev/api/people/");
            SetPlanets("https://swapi.dev/api/planets/");
            SetSpecies("https://swapi.dev/api/species/");
            SetStarships("https://swapi.dev/api/starships/");
            SetVehicles("https://swapi.dev/api/vehicles/");
        }         
   }
}

