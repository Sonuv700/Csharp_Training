using Assignment_1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "USA", Capital = "Washington, D.C." },
            new Country { ID = 2, CountryName = "Canada", Capital = "Ottawa" },
            new Country { ID = 3, CountryName = "Germany", Capital = "Berlin" },
            new Country { ID = 4, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 5, CountryName = "Japan", Capital = "Tokyo" },
            // Add more countries as needed
        };

        // GET: api/Country
        public IHttpActionResult GetCountries()
        {
            return Ok(countries);
        }

        // GET: api/Country/1
        public IHttpActionResult GetCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST: api/Country
        public IHttpActionResult PostCountry(Country country)
        {
            country.ID = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }

        // PUT: api/Country/1
        public IHttpActionResult PutCountry(int id, Country country)
        {
            var existingCountry = countries.FirstOrDefault(c => c.ID == id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;

            return Ok(existingCountry);
        }

        // DELETE: api/Country/1
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }

            countries.Remove(country);
            return Ok(country);
        }
    }
}
