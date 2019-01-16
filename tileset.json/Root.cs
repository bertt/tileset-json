using System.Numerics;

namespace Tileset.Json
{
    public class Root
    {
        public Boundingvolume BoundingVolume { get; set; }
        public float GeometricError { get; set; }
        public Child[] Children { get; set; }
        public string Refine { get; set; }
        public float[] Transform { get; set; }

        public Vector3 GetCenter()
        {
            return new Vector3(Transform[12], Transform[13], Transform[14]);
        }
    }
}
