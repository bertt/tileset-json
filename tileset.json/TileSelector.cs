using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace Tileset.Json
{
    public static class TileSelector
    {
        /**
         * root: Tiles to select from
         * TransformCenter: The Center of all tiles
         * CameraPosition: Well the camera center
         * CameraOrientation: Well the camera orientation
         * distancelod: array with distance/lod
         */
        // todo add camera orientation: add Vector3 cameraOrientation, 
        public static List<Child> GetTilesInView(Root root, Vector3 cameraPosition, double[] distanceLod)
        {
            // todo: use cameraOrientation
            var relativeCenterTile = root.Children[0].Children[0].BoundingVolume.GetCenter();
            var tileCenter = relativeCenterTile + root.GetCenter();

            // first print the distances to camera for each tile
            Debug.WriteLine("hallo");

            var distanceToCamera = (cameraPosition - tileCenter).Length();

            // The geometric error defines the error, in meters, when a tile is rendered, but its children are not.
            // Typically leaf tiles have a geometric error of 0.

            // todo: make a selection of the tiles based on camera point and orientation

            // also need to have a distance array for switchting between lod's

            return null;
        }
    }
}
