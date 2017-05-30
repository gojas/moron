﻿using System.Collections.Generic;

namespace Texture.GameObjectTextureDefinition
{
    public class CowboyStandingPistol : TextureDefinition
    {
        protected override string contentFile
        {
            get {
                return "cowboy_walking_pistol";
            }
        }

        protected override string[] spriteList
        {
            get {
                string[] a = {
                    "cowboy_walking_pistol_0_0"
                };

                return a;
            }
        }
    }

    public class CowboyBlockedPistol : TextureDefinition
    {
        protected override string contentFile
        {
            get
            {
                return "cowboy_walking_pistol";
            }
        }

        protected override string[] spriteList
        {
            get
            {
                string[] a = {
                    "cowboy_walking_pistol_0_0"
                };

                return a;
            }
        }
    }
}
