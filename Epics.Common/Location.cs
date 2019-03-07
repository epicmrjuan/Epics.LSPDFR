using Rage;

namespace Epics.Common
{
    public struct Location
    {
        public Vector3 vector;
        public float heading;

        public Location(Vector3 v, float h)
        {
            vector = v;
            heading = h;
        }
    }
}
