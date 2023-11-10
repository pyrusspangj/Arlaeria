using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.ModLoader;
using Terraria.Audio;
using Microsoft.Xna.Framework.Audio;

namespace Arlaeria.Items.Tiles
{
    internal class Charged_Ore_TILE : ModTile
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.


        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;

            Main.tileFrameImportant[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileShine[Type] = 900;
            Main.tileShine2[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 350;

            AddMapEntry(new Microsoft.Xna.Framework.Color(200, 200, 200), CreateMapEntryName());

            DustType = DustID.Tungsten;
            //ItemDrop = ModContent.ItemType<Placeables.Charged_Ore>();
            //SoundState = SoundID.Tink;
            //SoundStyle = 1;

            MineResist = 1.5f;
            MinPick = 55;

            //TileID.Sets.DisableSmartCursor[Type] = true;
            //TileID.Sets.IgnoredByNpcStepUp[Type] = true;

            //TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            //TileObjectData.newTile.CoordinateHeights = new[] { 18, 18 };
            //TileObjectData.addTile(Type);

            
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int itemType = ModContent.ItemType<Placeables.Charged_Ore>();

            Item.NewItem(
                new EntitySource_TileBreak(i, j),
                i * 16,
                j * 16,
                32,
                16,
                itemType
                );
        }
    }
}