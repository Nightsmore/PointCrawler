using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDots
{
    class Vector3
    {
        public float x, y, z;
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.z = z;
            this.y = y;
        }

        public static float Distance(Vector3 a, Vector3 b)
        {
            float f;

            Vector3 v = a - b;

            f = (v.x + v.y + v.z);

            return f;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        { 
            return new Vector3((a.x + b.x), (a.y + b.y), (a.z + b.z));
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3((a.x - b.x), (a.y - b.y), (a.z - b.z));
        }
    }
}
