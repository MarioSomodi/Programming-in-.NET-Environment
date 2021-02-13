using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Countries
{
    public class CountryRepository
    {
        public List<Country> GetCountries() 
        {
            var json = CallRestMethod("https://restcountries.eu/rest/v2/all");
            JArray jsonArray = JArray.Parse(json);
            List<Country> countries = new List<Country>();
            foreach (JObject jsonO in jsonArray)
            {
                string code, name, capital, region;
                int population;
                float area;

                if (String.IsNullOrWhiteSpace((string)jsonO.GetValue("alpha3Code")))
                {
                    code = "/";
                }
                else 
                {
                    code = (string)jsonO.GetValue("alpha3Code");
                }
                if (String.IsNullOrWhiteSpace((string)jsonO.GetValue("name")))
                {
                    name = "/";
                }
                else 
                {
                    name = (string)jsonO.GetValue("name");
                }
                if (String.IsNullOrWhiteSpace((string)jsonO.GetValue("capital")))
                {
                    capital = "/";
                }
                else 
                {
                    capital = (string)jsonO.GetValue("capital");
                }
                if (String.IsNullOrWhiteSpace(Convert.ToString((int)jsonO.GetValue("population"))))
                {
                    population = 0;
                }
                else 
                {
                    population = (int)jsonO.GetValue("population");
                }
                try
                {
                    area = (float)jsonO.GetValue("area");
                }
                catch (ArgumentException e)
                {
                    area = (float)0.0;
                }
                if (String.IsNullOrWhiteSpace(Convert.ToString((string)jsonO.GetValue("region"))))
                {
                    region = "/";
                }
                else
                {
                    region = (string)jsonO.GetValue("region");
                }

                countries.Add(new Country
                {
                    Code = code,
                    Name = name,
                    Capital = capital,
                    Population = population,
                    Area = area,
                    Region = region
                });
            }
            return countries;
        }
        public List<String> GetRegions() 
        {
            var countries = GetCountries();
            List<String> regions = new List<String>();
            regions = countries.Select(x => x.Region).Distinct().ToList();
            regions.Insert(0, "All");
            return regions;
        }
        public List<Country> Filter(List<Country> countries, string region, string name, string capital, int minPopulation, int maxPopulation) 
        {
            if (region != "All")
            {
                List<Country> filteredCountries = new List<Country>();
                bool filteringComplete = false;
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(capital) && minPopulation != 0 && maxPopulation != 0 && filteringComplete == false) 
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Name == name && x.Capital == capital && x.Population >= minPopulation && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(capital) && minPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Name == name && x.Capital == capital && x.Population >= minPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(capital) && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Name == name && x.Capital == capital && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(capital) && minPopulation != 0 && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Capital == capital && x.Population >= minPopulation && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(name) && minPopulation != 0 && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Name == name && x.Population >= minPopulation && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(capital) && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Name == name && x.Capital == capital).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(name) && minPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Name == name && x.Population >= minPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(name) && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Name == name && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(capital) && minPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Capital == capital && x.Population >= minPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(capital) && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Capital == capital && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && minPopulation != 0 && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Population >= minPopulation && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(name) && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Name == name).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && !String.IsNullOrWhiteSpace(capital) && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Capital == capital).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && minPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Population >= minPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Region == region && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(capital) && minPopulation != 0 && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Name == name && x.Capital == capital && x.Population >= minPopulation && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(capital) && minPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Name == name && x.Capital == capital && x.Population >= minPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(capital) && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Name == name && x.Capital == capital && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && minPopulation != 0 && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Name == name && x.Population >= minPopulation && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(capital) && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Name == name && x.Capital == capital).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && minPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Name == name && x.Population >= minPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Name == name && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(capital) && minPopulation != 0 && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Capital == capital && x.Population >= minPopulation && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && minPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Capital == capital && x.Population >= minPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(capital) && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Capital == capital && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (minPopulation != 0 && maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Population >= minPopulation && x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(region) && filteringComplete == false) 
                {
                    filteredCountries = countries.Where(x => x.Region == region).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(name) && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Name == name).ToList();
                    filteringComplete = true;
                }
                if (!String.IsNullOrWhiteSpace(capital) && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Capital == capital).ToList();
                    filteringComplete = true;
                }
                if (minPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Population >= minPopulation).ToList();
                    filteringComplete = true;
                }
                if (maxPopulation != 0 && filteringComplete == false)
                {
                    filteredCountries = countries.Where(x => x.Population <= maxPopulation).ToList();
                    filteringComplete = true;
                }
                return filteredCountries;
            }
            else 
            {
                return countries;
            }
        }
        private string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
    }
}
