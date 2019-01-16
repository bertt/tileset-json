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
            var files = new List<Child>();

            // select all tiles within 100m from camera
            var todownload = TileSelector.GetTiles(center, camera, rootobject.Root.Children[0], files, 100);
            Console.WriteLine("To download tiles: " + todownload.Count);
            Console.ReadKey();
        }

    }
}
