using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop-2023-ca1-25933
{
    internal class Park
    {
        public String Customer { get; set; }
        public int Garage { get; set; }
        public double Hours { get; set; }
        
        public Park(int garage) 
        { 
            Garage = garage;
        }   

        public Park(int customer, int garage, double hours)
            :this(garage)
        {
            this.Customer = customer;
            this.Garage = garage;
            this.Hours = hours;

        }




    }
}


