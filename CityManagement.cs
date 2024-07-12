using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class CityManagement
    {
         public List<string> cities = new List<string>();

       

        public void AddCity(string name)
        {
            cities.Add(name); 
        }

        public void AddCity(List<string> name)
        {
            cities.AddRange(name);  
        }

        public void find(string a)
        {
            foreach(string pd in cities)
            {
                if(pd == a)
                {
                    Console.WriteLine(pd);
                }
            }
        }

        public void find(string a,string b)
        {
            foreach (string pd in cities)
            {
                if (pd == a || pd==b)
                {
                    Console.WriteLine(pd);
                }
            }

        }

    }
}
