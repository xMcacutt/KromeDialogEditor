using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty1_DLG_Editor
{
    internal class Cell
    {
        public string LipAnim;
        public string HeadAnim;
        public string BodyAnim;
        public int LipScaler;
        public int HeadType;
        public int BodyType;
        public bool Speaking;
        public bool FitBodyAnim;
        public bool FitHeadAnim;
        public string ActorPos;
        public string ActorRot;

        public Cell(string lip, int lipScaler, string head, int headType, string body, int bodyType, bool speaking, bool fitHead, bool fitBody, string pos, string rot)
        {
            this.LipAnim = lip;
            this.LipScaler = lipScaler;
            this.HeadAnim = head;
            this.HeadType = headType;
            this.BodyAnim = body;
            this.BodyType = bodyType;
            this.Speaking = speaking;
            this.FitBodyAnim = fitBody;
            this.FitHeadAnim = fitHead;
            this.ActorPos = pos;
            this.ActorRot = rot;
        }
    }
}
