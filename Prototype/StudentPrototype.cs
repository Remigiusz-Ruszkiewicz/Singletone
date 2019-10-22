using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{

    public class StudentPrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public StudentPrototype Clone()
        {
            return new StudentPrototype
            {
                Id =Id,
                Name = Name,
                LastName =LastName
            };
        }
        public override string ToString()
        {
            return $"Id: {Id}, Imię: {Name}, Nazwisko: {LastName}";
        }
    }
}
