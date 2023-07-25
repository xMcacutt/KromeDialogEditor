using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty1_DLG_Editor
{
    internal class Camera
    {
        public int Index;
        public float FOV;
        public float NearPlane;
        public float FarPlane;
        public float CamTime;
        public bool ForceLength;
        public BindingList<TCBInfo> TCBInfos = new();
        public BindingList<CamSpline> CamSplines = new();

        public Camera(int index, float FOV, float nearPlane, float farPlane, float camTime, bool forceLength)
        {
            this.Index = index;
            this.FOV = FOV;
            this.NearPlane = nearPlane;
            this.FarPlane = farPlane;
            this.CamTime = camTime;
            this.ForceLength = forceLength;
        }

        public override string ToString()
        {
            return "Camera " + Index;
        }
    }
}
