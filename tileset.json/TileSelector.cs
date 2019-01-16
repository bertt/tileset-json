using System.Collections.Generic;
using System.Numerics;

namespace Tileset.Json
{
    public static class TileSelector
    {
        public static List<Child> GetTiles(Vector3 center, Vector3 camera, Child child, List<Child> files, double maxDistance)
        {
            var tileCenter = child.BoundingVolume.GetCenter() + center;
            var distanceToCamera = (camera - tileCenter).Length();
            if (distanceToCamera < maxDistance)
            {
                files.Add(child);
            }
            foreach (var c in child.Children)
            {
                files = GetTiles(center, camera, c, files, maxDistance);
            }
            return files;
        }
    }
}
