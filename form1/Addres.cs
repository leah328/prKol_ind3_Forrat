using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace адрес
{
    class Addres
    {
        private string street;
        private string city;
        private string state;
        private string code;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public void Update(string state, string city, string street, string code)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.code = code;
        }

        public string Getinfo()
        {
            return $"{this.state},{this.city},{this.street},{this.code}";
        }

       

    }
}
