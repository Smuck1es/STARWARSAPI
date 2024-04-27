using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsAPI
{
    internal class JSONHelper
    {
        static readonly HttpClient client = new HttpClient();
        public static async Task<Planet> GetPlanet(string planetID)
        {
            Planet myDeserializedClass = new Planet();

            try
            {
                HttpResponseMessage response = await client.GetAsync($"https://swapi.py4e.com/api/planets/{planetID}/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                myDeserializedClass = JsonConvert.DeserializeObject<Planet>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }
        public static async Task<Person> GetPerson(string peopleID)
        {
            Person myDeserializedClass = new Person();

            try
            {
                HttpResponseMessage response = await client.GetAsync($"https://swapi.py4e.com/api/people/{peopleID}/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                myDeserializedClass = JsonConvert.DeserializeObject<Person>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }

        public static async Task<Starship> GetStarshipName(string starshipUrl)
        {
            Starship myDeserializedClass = new Starship();

            try
            {
                HttpResponseMessage response = await client.GetAsync(starshipUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                myDeserializedClass = JsonConvert.DeserializeObject<Starship>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }

        public static async Task<Species> GetSpecies(string speciesID)
        {
            Species myDeserializedClass = new Species();

            try
            {
                HttpResponseMessage response = await client.GetAsync($"https://swapi.py4e.com/api/species/{speciesID}/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                myDeserializedClass = JsonConvert.DeserializeObject<Species>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }

        public static async Task<AllSpecies> GetAllSpecies() 
        {
            AllSpecies myDeserializedClass = new AllSpecies();

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.py4e.com/api/species/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                myDeserializedClass = JsonConvert.DeserializeObject<AllSpecies>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }
    }
}
