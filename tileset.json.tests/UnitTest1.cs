using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Tileset.Json;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestB3dmTileSetJson()
        {
            // arrange
            var infile = "./testfixtures/b3dm.tileset.json";
            var stream = File.OpenRead(infile);

            // act
            var rootobject = TilesetJsonParser.ParseTilesetJson(stream);

            // assert
            Assert.IsTrue(rootobject.Asset.Version == "1.0");
            Assert.IsTrue(rootobject.GeometricError == 500);
            Assert.IsTrue(rootobject.Root.GetCenter()!=null);
            Assert.IsTrue(rootobject.Root.Transform.Length == 16);
            Assert.IsTrue(rootobject.Root.Children[0].Children[0].Children.Length == 2);
            Assert.IsTrue(rootobject.Root.Children[0].Children[0].Children[0].Content.Url == "tiles/3.b3dm");
        }

        [Test]
        public void TestTileSelectorTileSetJson()
        {
            // arrange
            var infile = "./testfixtures/b3dm.tileset.json";
            var stream = File.OpenRead(infile);
            var rootobject = TilesetJsonParser.ParseTilesetJson(stream);
            var cameraPosition = rootobject.Root.GetCenter() + new Vector3(0,0,100);
            double max_distance = 100;
            var center = rootobject.Root.GetCenter();
            var camera = rootobject.Root.GetCenter() + new Vector3(0, 0, 100);
            var files = new List<Child>();

            // act: select all tiles within 100m from camera
            var tiles = TileSelector.GetTiles(center, camera, rootobject.Root.Children[0], files, max_distance);

            // assert
            Assert.IsTrue(tiles.Count==18);
        }



        [Test]
        public void TestPntsTileSetJson()
        {
            var infile = "./testfixtures/pnts.tileset.json";
            var stream = File.OpenRead(infile);
            var rootobject = TilesetJsonParser.ParseTilesetJson(stream);
            Assert.IsTrue(rootobject.Asset.Version == "0.0");
            Assert.IsTrue(rootobject.GeometricError == 33.625);
        }
    }
}