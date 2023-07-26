using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty1_DLG_Editor
{
    internal class Actor
    {
        public string Name;
        public string Model;
        public string BadPath;
        public Dictionary<int, Cell> Cells = new();
        public BindingList<string> LipAnims;
        public BindingList<string> HeadAnims;
        public BindingList<string> BodyAnims;
        
        public Actor(string name, string model, string badPath) 
        { 
            this.Name = name;
            this.Model = model;
            this.BadPath = badPath;
            ProcessBadFile();
        }

        public override string ToString()
        {
            return Name + " | " + Model;
        }

        public void ProcessBadFile()
        {
            LipAnims = new();
            HeadAnims = new();
            BodyAnims = new();
            string[] lines = File.ReadAllLines(BadPath);
            foreach(string line in lines)
            {
                if (!line.StartsWith("anim")) continue;
                string animName = line.Split(' ')[1];
                if (animName.StartsWith("Lips"))
                {
                    LipAnims.Add(animName);
                    continue;
                }
                if (animName.StartsWith("Head"))
                {
                    HeadAnims.Add(animName);
                    continue;
                }
                BodyAnims.Add(animName);
            }
        }
    }
}
