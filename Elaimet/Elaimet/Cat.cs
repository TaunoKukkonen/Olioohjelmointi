using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    internal class Cat
    {


            private int age;
            public string name;


        public Cat()
            {

            }


        public Cat(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
        public void setKissaname(string name)
            {
                this.name = name;
            }
        public void setKissaage(int age)
            {
                this.age = age;
            }

        public int returnage()
            {
                return age;
            }
        public string returnKissaname()
            {
                return name;
            }
        
    }
}
