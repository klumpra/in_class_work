using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarWorld.Models;
using GuitarWorld.Views;
namespace GuitarWorld.Controllers
{
    public class GuitarController
    {
        private List<Guitar> guitars;
        public GuitarController()
        {
            guitars = new List<Guitar>();
        }
        public void AddGuitar(string name, string manufacturer, string model, int year)
        {
            Guitar? existing = guitars.Find(g => g.Name == name);
            Guitar newOne;
            if (existing == null)
            {
                newOne = new Guitar(name, manufacturer, model, year);
                guitars.Add(newOne);
            } else
            {
                existing.Manufacturer = manufacturer;
                existing.Model = model;
                existing.Year = year;
            }
        }
        public List<String> GetGuitarNames()
        {
            List<string> names = new List<string>();
            foreach (Guitar g in guitars)
            {
                names.Add(g.Name);
            }
            return names;
        }
        public List<string> GetTextOfAllGuitars()
        {
            List<string> result = new List<string>();
            foreach (Guitar g in guitars)
            {
                result.Add($"Name: {g.Name}");
                result.Add($"Manufacturer: {g.Manufacturer}");
                result.Add($"Model: {g.Model}");
                result.Add($"Year: {g.Year}");
                result.Add("");
            }
            return result;
        }
        public bool ValidateEntries(string name, string manuf, string model, int year)
        {
            if (name == "" || manuf == "" || model == "")
            {
                return false;
            } else
            {
                return true;
            }
        }

        public Dictionary<string,string> GetGuitarDetails(string name)
        {
            Guitar? existing = guitars.Find(g => g.Name == name);
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (existing != null)
            {
                result.Add("name", existing.Name);
                result.Add("manufacturer", existing.Manufacturer);
                result.Add("model", existing.Model);
                result.Add("year", $"{existing.Year}");
                return result;
            } else
            {
                return null;
            }
        }
    }
}
