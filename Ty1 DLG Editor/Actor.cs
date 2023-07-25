using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty1_DLG_Editor
{
    internal class Actor
    {
        public string Name;
        public string Model;
        public Dictionary<int, Cell> Cells = new();
        
        public Actor(string name, string model) 
        { 
            this.Name = name;
            this.Model = model;
        }

        public override string ToString()
        {
            return Name + " | " + Model;
        }
    }
}
