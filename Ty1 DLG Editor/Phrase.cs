using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty1_DLG_Editor
{
    internal class Phrase
    {
        public int Index;
        public int CamIndex;
        public List<string> EffectParams;
        public float EffectDelay;

        public Phrase(int index, int camIndex, List<string> effectParams, float effectDelay)
        {
            this.Index = index;
            this.CamIndex = camIndex;
            this.EffectParams = effectParams;
            this.EffectDelay = effectDelay;
        }

        public override string ToString()
        {
            return "Phrase " + Index;
        }
    }
}
