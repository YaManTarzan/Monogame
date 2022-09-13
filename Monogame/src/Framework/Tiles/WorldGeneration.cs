using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Tiles
{
    struct BiomeCoords
    {
        Vector2 TopLeft;
        Vector2 BottomRight;
    }

    enum Biomes
    {
        SKY,
        DESERT,
        OCEAN,
        BEACH,
        FOREST,
        DARKFOREST,
        LIGHTFOREST,
        PLAINS,
        UNDERGROUND,
        CAVERNS,
        HELL,
        SPACE,
    }


    public class WorldGeneration
    {
        private TileMap _map;
        private Biomes currentBiome;

        private Random rand;

        // Amount of each biome
        private int SkyBiomes;
        private int DesertBiomes;
        private int OceanBiomes;
        private int BeachBiomes;
        private int ForestBiomes;
        private int DarkForestBiomes;
        private int LightForestBiomes;
        private int PlainsBiomes;
        private int UndergroundBiomes;
        private int CavernsBiomes;
        private int HellBiomes;
        private int SpaceBiomes;

        // All coordinates for every biome
        private BiomeCoords[] SkyPositions;
        private BiomeCoords[] DesertPositions;
        private BiomeCoords[] OceanPositions;
        private BiomeCoords[] BeachPositions;
        private BiomeCoords[] ForestPositions;
        private BiomeCoords[] DarkForestPositions;
        private BiomeCoords[] LightForestPositions;
        private BiomeCoords[] PlainsPositions;
        private BiomeCoords[] UndergroundPositions;
        private BiomeCoords[] CavernsPositions;
        private BiomeCoords[] HellPositions;
        private BiomeCoords[] SpacePositions;

        // Takes in a tile map and how many of each biome is wanted
        public WorldGeneration(
            TileMap map,
            int SkyBiomes,
            int DesertBiomes,
            int OceanBiomes,
            int BeachBiomes,
            int ForestBiomes,
            int DarkForestBiomes,
            int LightForestBiomes,
            int PlainsBiomes,
            int UndergroundBiomes,
            int CavernsBiomes,
            int HellBiomes,
            int SpaceBiomes
            )
        {
            _map = map;
            // INitialize the number of each biome your going to have
           this.SkyBiomes = SkyBiomes;
           this.DesertBiomes = DesertBiomes;
           this.OceanBiomes = OceanBiomes;
           this.BeachBiomes = BeachBiomes;
           this.ForestBiomes = ForestBiomes;
           this.DarkForestBiomes = DarkForestBiomes;
           this.LightForestBiomes = LightForestBiomes;
           this.PlainsBiomes = PlainsBiomes;
           this.UndergroundBiomes = UndergroundBiomes;
           this.CavernsBiomes = CavernsBiomes;
           this.HellBiomes = HellBiomes;
           this.SpaceBiomes = SpaceBiomes;

            // Initialize all of the biome positions arrays to be the 
            // Size of how many biomes they are going to hold
           SkyPositions = new BiomeCoords[SkyBiomes];
           DesertPositions = new BiomeCoords[DesertBiomes];
           OceanPositions = new BiomeCoords[OceanBiomes];
           BeachPositions = new BiomeCoords[BeachBiomes];
           ForestPositions = new BiomeCoords[ForestBiomes];
           DarkForestPositions = new BiomeCoords[DarkForestBiomes];
           LightForestPositions = new BiomeCoords[LightForestBiomes];
           PlainsPositions = new BiomeCoords[PlainsBiomes];
           UndergroundPositions = new BiomeCoords[UndergroundBiomes];
           CavernsPositions = new BiomeCoords[CavernsBiomes];
           HellPositions = new BiomeCoords[HellBiomes];
           SpacePositions = new BiomeCoords[SpaceBiomes];
        }

        public void GenBiomes()
        {

        }

        public void FillMap()
        {
            for (int c = 0; c < _map.cols; c++)
            {
                for (int r = 0; r < _map.rows; r++)
                {
                    switch(currentBiome)
                    {
                        case Biomes.SKY:
                            Sky();
                            break;
                        case Biomes.BEACH:
                            Beach();
                            break;
                        case Biomes.OCEAN:
                            Ocean();
                            break;
                        case Biomes.CAVERNS:
                            Caverns();
                            break;
                        case Biomes.FOREST:
                            Forest();
                            break;
                        case Biomes.DARKFOREST:
                            DarkForest();
                            break;
                        case Biomes.LIGHTFOREST:
                            LightForest();
                            break;
                        case Biomes.PLAINS:
                            Plains();
                            break;
                        case Biomes.HELL:
                            Hell();
                            break;
                        case Biomes.UNDERGROUND:
                            UnderGround();
                            break;
                        case Biomes.DESERT:
                            Desert();
                            break;
                    }
                }
            }

        }

        public void Sky()
        {

        }

        public void Desert()
        {

        }

        public void Ocean()
        {

        }
        
        public void Beach()
        {

        }

        public void Forest()
        {

        }

        public void DarkForest()
        {

        }

        public void LightForest()
        {

        }

        public void Plains()
        {

        }

        public void UnderGround()
        {

        }

        public void Caverns()
        {

        }

        public void Hell()
        {

        }
    }
}
