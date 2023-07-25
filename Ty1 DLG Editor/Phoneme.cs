using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty1_DLG_Editor
{
    internal class Phoneme
    {
        public string Name;
        public int SubtitleNr;
        public float InTime;
        public float OutTime;

        public Phoneme(string name, int subtitleNr, float inTime, float outTime)
        {
            this.Name = name;
            this.SubtitleNr = subtitleNr; 
            this.InTime = inTime;
            this.OutTime = outTime;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
