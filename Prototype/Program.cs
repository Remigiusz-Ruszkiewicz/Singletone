using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {

        static void Main(string[] args)
        {
            //var prototype = new ForkliftPrototype
            //{
            //    Name = "Default",
            //    ProductionYear = 2019,
            //    Type = "Electric",
            //    Size = new Size
            //    {
            //        Width = 500,
            //        Height=1000
            //    }

            //};
            //Console.WriteLine("Default");
            //Console.WriteLine(prototype);
            //var nowazmienna = prototype.Clone();
            //nowazmienna.Name = "LOL";
            //nowazmienna.Type = "Jakis";
            //Console.WriteLine(nowazmienna);
            //var Id = new IdNr.Instance(Id);

            var us = IdNr.Instance();
            var student = new StudentPrototype
            {
                Id = 2,
                Name = "Imię",
                LastName = "Nazwisko"
            };
            Console.WriteLine(student);
            Console.Read();
        }
    }
}
