using System;
using System.IO;
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
            PrintTileAndChildren(rootobject.Root.Children[0]);
            Console.ReadKey();
        }

        private static void PrintTileAndChildren(Child child)
        {
            Console.WriteLine(child.Content.Url + ", " + child.GeometricError);

            foreach(var c in child.Children)
            {
                PrintTileAndChildren(c);
            }
        }
    }
}
