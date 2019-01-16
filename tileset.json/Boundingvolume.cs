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
    }
}
