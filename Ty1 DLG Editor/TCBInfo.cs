using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty1_DLG_Editor
{
    internal class TCBInfo
    {
        public int Index;
        public float Weight1;
        public float Weight2;

        public TCBInfo(int index, float weight1, float weight2)
        {
            this.Index = index;
            this.Weight1 = weight1;
            this.Weight2 = weight2;
        }

        public override string ToString()
        {
            return "TCB " + Index;
        }
    }
}
