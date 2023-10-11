using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    public class Departament
    {
        private string Name {  get; set; }
        public Departament() { }
        public Departament(string name)
        {
            Name = name;
        }
    }
}
