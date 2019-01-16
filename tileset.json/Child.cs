namespace Tileset.Json
{
    public class Child
    {
        public Boundingvolume BoundingVolume { get; set; }
        public float GeometricError { get; set; }
        public Child[] Children { get; set; }
        public string Refine { get; set; }
        public Content Content { get; set; }
    }
}
