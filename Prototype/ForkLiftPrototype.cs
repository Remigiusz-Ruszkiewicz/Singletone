using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
        public class ForkliftPrototype

        {
            public string Name { get; set; }
            public int ProductionYear { get; set; }
            public string Type { get; set; }
            public Size Size { get; set; }
            public ForkliftPrototype Clone()
            {
                return new ForkliftPrototype
                {
                    Name = Name,
                    ProductionYear = ProductionYear,
                    Type = Type,
                    Size = new Size()
                    {
                        Height = Size.Height,
                        Width = Size.Width
                    }
                };
            }
            public override string ToString()
            {
                return $"Nazwa: {Name}, Rok produkcji: {ProductionYear}, Typ: {Type}, Rozmiar: H - {Size.Height}, W - {Size.Width}";
            }
        }
        public class Size
        {
            public int Height { get; set; }
            public int Width { get; set; }
        }
    
}
