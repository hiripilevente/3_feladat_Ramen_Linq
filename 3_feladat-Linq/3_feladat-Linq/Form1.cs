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

        public Form1()
        {
            InitializeComponent();
            LoadData("ramen.csv");
        }

        public void LoadData(string FileName)
        {
            using (StreamReader sr= new StreamReader(FileName, Encoding.Default)) 
            {
                sr.ReadLine();  //Header
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    var countryName = line[2];
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
                }
            
            }

        }
    }
}
