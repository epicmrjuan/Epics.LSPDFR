using Rage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epics.Common
{
    public static class Random
    {
        public static Vector3 GetRandomFromArray(Vector3[] vector)
        {
            System.Random r = new System.Random();
            int index = r.Next(0, vector.Length);
            return vector[index];
        }
    }
}
