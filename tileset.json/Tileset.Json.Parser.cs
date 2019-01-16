using Newtonsoft.Json;
using System.IO;

namespace Tileset.Json
{

    public static class TilesetJsonParser
    {
        public static Rootobject ParseTilesetJson(Stream stream)
        {
            var reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            var rootobject = JsonConvert.DeserializeObject<Rootobject>(json);
            return rootobject;
        }
    }

}
