using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class IdNr
    {
        public int Id { get; private set; } = 0;

        private static IdNr instance;
        protected IdNr() { }
        public static IdNr Instance()
        {
            if (instance == null)
            {
                instance = new IdNr();
            }
            instance.Id++;
            return instance;
        }
    }
}
