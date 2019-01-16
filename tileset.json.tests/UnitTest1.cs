using NUnit.Framework;
using System.IO;
using Tileset.Json;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestB3dmTileSetJson()
        {
            var infile = "./testfixtures/b3dm.tileset.json";
            var stream = File.OpenRead(infile);
            var rootobject = TilesetJsonParser.ParseTilesetJson(stream);
            Assert.IsTrue(rootobject.asset.version == "1.0");
            Assert.IsTrue(rootobject.geometricError == 500);
        }


        [Test]
        public void TestPntsTileSetJson()
        {
            var infile = "./testfixtures/pnts.tileset.json";
            var stream = File.OpenRead(infile);
            var rootobject = TilesetJsonParser.ParseTilesetJson(stream);
            Assert.IsTrue(rootobject.asset.version == "0.0");
            Assert.IsTrue(rootobject.geometricError == 33.625);
        }

    }
}