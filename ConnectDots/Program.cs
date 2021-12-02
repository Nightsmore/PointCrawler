using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConnectDots
{
    class Program
    {
        static Vector3[] points = {
            new Vector3(0,0,0),
            new Vector3(3,0,0),
            new Vector3(0,0,0),
            new Vector3(-3,0,0)
        };

        static Vector3[] sides = {
            new Vector3(1,0,0),
            new Vector3(-0,0,0),
            new Vector3(0,1,0),
            new Vector3(0,-1,0),
            new Vector3(0,0,1),
            new Vector3(0,0,-1),
        };

        static Vector3 reletivePointA = new Vector3(5, 27, 0);
        static Vector3 reletivePointB = new Vector3(18, 13, 0);


        static int pointsIndex;

        static Vector3 _vect = new Vector3(0, 0, 0);

        static bool isRunning;

        static void Main(string[] args)
        {
            pointsIndex = 0;

            isRunning = true;
            
            while(isRunning)
            {
                System.Threading.Thread.Sleep(100);
                IncrementRotation();
                Console.WriteLine($"Vector3 - x: {_vect.x} y: {_vect.y} z: {_vect.z}");

            }

            Console.ReadKey();
        }

        #region FunMethods

        static void IncrementRotation()
        {
            //Console.WriteLine($"\npointsIndex: {pointsIndex}\npoints.Length: {points.Length}");

            if (pointsIndex == points.Length)
            {
                pointsIndex = 0;
                return;
            }

            if (Math.Round(_vect.x) == points[pointsIndex].x)
            {
                pointsIndex++;
                return;
            }

            if (_vect.x != points[pointsIndex].x)
            {
                _vect.x += Crawl(_vect.x, points[pointsIndex].x); // * Time.deltaTime; 
            }
        }

        static float Crawl(float val, float direction)
        {

            // move towards the desired value (direction)

            float returnValue = 0.0f;
     
            if (val == direction)
            { 
                return returnValue; // the value is the same
            }

            var temp = val;

            temp += 0.1f;

            if (GetDifference(direction,temp) < GetDifference(direction,val))
            {
                return 0.1f;
            }

            temp = val; // reset
            temp += -0.1f;

            if (GetDifference(direction,temp) < GetDifference(direction,val))
            {
                return -0.1f;
            }

            return returnValue;

        }

        static float GetDifference(float a, float b)
        {
            float lower, higher; 

            if(a > b) { lower = b; higher = a; } else { lower = a; higher = b; }

            var f = (higher - lower);

            return f;
        }

        #endregion
    }
}
