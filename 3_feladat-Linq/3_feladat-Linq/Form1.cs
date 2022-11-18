using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_feladat_Linq
{
    public partial class Form1 : Form
    {
        List<Country> countries = new List<Country>();
        List<Ramen> ramens = new List<Ramen>();

        public Form1()
        {
            InitializeComponent();
            LoadData("ramen.csv");
        }

        private void LoadData(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
            {
                sr.ReadLine(); // Header
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');

                    var countryName = line[2];
                    var country = AddCountry(countryName);

                    var ramen = new Ramen()
                    {
                        RamenId= ramens.Count + 1,
                        Brand = line[0],
                        RamenName = line[1],
                        CountryFK = country.CountryID,
                        Country = country,
                        Stars = Convert.ToDouble(line[3])
                    };
                    ramens.Add(ramen);
                }
            }
        }

        private Country AddCountry(string countryName)
        {
            var currentCountry = (from c in countries
                                  where c.Name.Equals(countryName)
                                  select c).FirstOrDefault();
            if (currentCountry == null)
            {
                currentCountry = new Country()
                {
                    CountryID = countries.Count + 1,
                    Name = countryName
                };
                countries.Add(currentCountry);
            }

            return currentCountry;
        }
    }
}
