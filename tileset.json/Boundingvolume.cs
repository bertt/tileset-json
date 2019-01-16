using System.Numerics;

namespace Tileset.Json
{
    public class Boundingvolume
    {
        public float[] Box { get; set; }

        public Vector3 GetCenter()
        {
            return new Vector3(Box[0], Box[1], Box[2]);
        }

        public Vector3 GetRotation()
        {
            // q: is this correct?
            return new Vector3(Box[3], Box[7], Box[11]);
        }
    }
}
