namespace Tileset.Json
{
    public class Root
    {
        public Boundingvolume BoundingVolume { get; set; }
        public float GeometricError { get; set; }
        public Child[] Children { get; set; }
        public string Refine { get; set; }
        public float[] Transform { get; set; }
    }
}
