namespace Tileset.Json
{

    public class Rootobject
    {
        public Asset Asset { get; set; }
        public float GeometricError { get; set; }
        public Root Root { get; set; }
    }

    public class Asset
    {
        public string Version { get; set; }
        public string GltfUpAxis { get; set; }
    }

    public class Boundingvolume
    {
        public float[] Box { get; set; }
    }

    public class Root
    {
        public Boundingvolume BoundingVolume { get; set; }
        public float GeometricError { get; set; }
        public Child[] Children { get; set; }
        public string Refine { get; set; }
        public float[] Transform { get; set; }
    }

    public class Child
    {
        public Boundingvolume BoundingVolume { get; set; }
        public float GeometricError { get; set; }
        public Child[] Children { get; set; }
        public string Refine { get; set; }
        public Content Content { get; set; }
    }

    public class Content
    {
        public string Url { get; set; }
    }
}
