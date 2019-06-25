using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace NamespaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Multidimision array
            //int[,] intArr = { {15,17,9 },{25,75,100 } };
            //string[,] strArr = { {"Ferid","Cavid" }, {"Aynur","Firuze"} };
            //int[,,] d3Arr ={ { {1,2 },{3,4 } },{ {5,6 },{7,8 } } };
            //Console.WriteLine(d3Arr[1,0,0]);
            #endregion

            //StringBuilder strb = new StringBuilder();

            //Second.Person person = new Second.Person();
            //Woman woman = new Woman();
            //Man man = new Man();
            //Engineer engineer = new Engineer();

            //Flower flower = new Flower();
            //Plant plant = new Plant();

            Person person = new Person();
            //person.SetEmail("kamrancode.edu.az");
            person.Name = "asdfghj";

            //Console.WriteLine(person.GetEmail());

            person.Email = "kamran@code.edu.az";
            int x=person.MyProperty;
            Console.WriteLine(person.Email);

            Tree tree = new Tree();



        }
    }

    class Woman : Person
    {
        public Woman()
        {
           
        }
    }

    public class Person
    {
        public string Name;
        public string Surname;
        public DateTime Birthday;
        private string _email;
        public int MyProperty { get;private set; }

        public string Email
        {
            set
            {
                if (value.IndexOf('@') != -1)
                {
                    _email = value;
                }
            }
            get
            {
                return _email;
            }
        }

        protected string GetEmail()
        {
            return _email;
        }

        //public void SetEmail(string email)
        //{
        //    if (email.IndexOf('@') != -1)
        //    {
        //        _email = email;
        //    }
        //}
    }

}
