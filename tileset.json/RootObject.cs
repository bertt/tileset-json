namespace Tileset.Json
{

    public class Rootobject
    {
        public Asset asset { get; set; }
        public float geometricError { get; set; }
        public Root root { get; set; }
    }

    public class Asset
    {
        public string version { get; set; }
        public string gltfUpAxis { get; set; }
    }

    public class Root
    {
        public Boundingvolume boundingVolume { get; set; }
        public float geometricError { get; set; }
        public Child[] children { get; set; }
        public string refine { get; set; }
        public float[] transform { get; set; }
    }

    public class Boundingvolume
    {
        public float[] box { get; set; }
    }

    public class Child
    {
        public Boundingvolume1 boundingVolume { get; set; }
        public float geometricError { get; set; }
        public Child1[] children { get; set; }
        public string refine { get; set; }
        public Content content { get; set; }
    }

    public class Boundingvolume1
    {
        public float[] box { get; set; }
    }

    public class Content
    {
        public string url { get; set; }
    }

    public class Child1
    {
        public Boundingvolume2 boundingVolume { get; set; }
        public float geometricError { get; set; }
        public Child2[] children { get; set; }
        public string refine { get; set; }
        public Content1 content { get; set; }
    }

    public class Boundingvolume2
    {
        public float[] box { get; set; }
    }

    public class Content1
    {
        public string url { get; set; }
    }

    public class Child2
    {
        public Boundingvolume3 boundingVolume { get; set; }
        public float geometricError { get; set; }
        public Child3[] children { get; set; }
        public string refine { get; set; }
        public Content2 content { get; set; }
    }

    public class Boundingvolume3
    {
        public float[] box { get; set; }
    }

    public class Content2
    {
        public string url { get; set; }
    }

    public class Child3
    {
        public Boundingvolume4 boundingVolume { get; set; }
        public float geometricError { get; set; }
        public Child4[] children { get; set; }
        public string refine { get; set; }
        public Content3 content { get; set; }
    }

    public class Boundingvolume4
    {
        public float[] box { get; set; }
    }

    public class Content3
    {
        public string url { get; set; }
    }

    public class Child4
    {
        public Boundingvolume5 boundingVolume { get; set; }
        public float geometricError { get; set; }
        public Child5[] children { get; set; }
        public string refine { get; set; }
        public Content4 content { get; set; }
    }

    public class Boundingvolume5
    {
        public float[] box { get; set; }
    }

    public class Content4
    {
        public string url { get; set; }
    }

    public class Child5
    {
        public Boundingvolume6 boundingVolume { get; set; }
        public float geometricError { get; set; }
        public Child6[] children { get; set; }
        public string refine { get; set; }
        public Content5 content { get; set; }
    }

    public class Boundingvolume6
    {
        public float[] box { get; set; }
    }

    public class Content5
    {
        public string url { get; set; }
    }

    public class Child6
    {
        public Boundingvolume7 boundingVolume { get; set; }
        public float geometricError { get; set; }
        public Child7[] children { get; set; }
        public string refine { get; set; }
        public Content6 content { get; set; }
    }

    public class Boundingvolume7
    {
        public float[] box { get; set; }
    }

    public class Content6
    {
        public string url { get; set; }
    }

    public class Child7
    {
        public Boundingvolume8 boundingVolume { get; set; }
        public float geometricError { get; set; }
        public object[] children { get; set; }
        public string refine { get; set; }
        public Content7 content { get; set; }
    }

    public class Boundingvolume8
    {
        public float[] box { get; set; }
    }

    public class Content7
    {
        public string url { get; set; }
    }

}
