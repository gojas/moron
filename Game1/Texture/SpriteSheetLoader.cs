using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace Texture
{
    class SpriteSheetLoader
    {
        private readonly ContentManager contentManager;

        public SpriteSheetLoader(ContentManager aContentManager)
        {
            contentManager = aContentManager;
        }

        public SpriteSheetContainer load(string imageResource)
        {
            var texture = contentManager.Load<Texture2D>(imageResource);

            var dataFile = Path.Combine(
                contentManager.RootDirectory,
                Path.ChangeExtension(imageResource, "txt"));

            var dataFileLines = readDataFile(dataFile);

            var sheet = new SpriteSheetContainer();

            foreach (
                var cols in
                    from row in dataFileLines
                    where !string.IsNullOrEmpty(row) && !row.StartsWith("#")
                    select row.Split(';'))
            {
                if (cols.Length != 10)
                {
                    throw new InvalidDataException("Incorrect format data in spritesheet data file");
                }

                var name = cols[0];
                var sourceRectangle = new Rectangle(
                    int.Parse(cols[2]),
                    int.Parse(cols[3]),
                    int.Parse(cols[4]),
                    int.Parse(cols[5]));
                var size = new Vector2(
                    int.Parse(cols[6]),
                    int.Parse(cols[7]));
                var pivotPoint = new Vector2(
                    float.Parse(cols[8]),
                    float.Parse(cols[9]));
                var sprite = new Sprite(texture, sourceRectangle, size, pivotPoint);

                sheet.Add(name, sprite);
            }

            return sheet;
        }

        private string[] readDataFile(string dataFile)
        {
            return File.ReadAllLines(dataFile);
        }


    }
}
