using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty1_DLG_Editor
{
    internal class CamSpline
    {
        public int Index;
        public string Source;
        public string Target;

        public CamSpline(int index, string source, string target)
        {
            this.Index = index;
            this.Source = source;
            this.Target = target;
        }

        public override string ToString()
        {
            return "CamSpline " + Index;
        }
    }
}
