using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Tileset.Json;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var infile = "b3dm.tileset.json";
            var stream = File.OpenRead(infile);
            var rootobject = TilesetJsonParser.ParseTilesetJson(stream);
            var center = rootobject.Root.GetCenter();
            var camera = rootobject.Root.GetCenter() + new Vector3(0, 0, 100);
            var files = new List<String>();

            // select all tiles within 200m from camera
            var todownload = PrintTileAndChildren(center, camera, rootobject.Root.Children[0], files, 100);
            Console.WriteLine("To download tiles: " + todownload.Count);
            Console.ReadKey();
        }

        private static List<string> PrintTileAndChildren(Vector3 center, Vector3 camera, Child child, List<string> files, double maxDistance)
        {
            var tileCenter = child.BoundingVolume.GetCenter() + center;
            var distanceToCamera = (camera - tileCenter).Length();
            Console.WriteLine(child.Content.Url + ", " + child.GeometricError + ", " + distanceToCamera);
            if (distanceToCamera < maxDistance)
            {
                files.Add(child.Content.Url);
            }
            foreach (var c in child.Children)
            {
                files = PrintTileAndChildren(center, camera, c, files, maxDistance);
            }
            return files;
        }
    }
}
