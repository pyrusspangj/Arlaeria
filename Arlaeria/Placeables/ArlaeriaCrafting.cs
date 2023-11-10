using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Arlaeria.Placeables
{
    internal class ArlaeriaCrafting : ModItem
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Elliotic Condenser");
            //Tooltip.SetDefault("Harness the elements.");
            //CreativeItemSacrificesCatalog.Instance.SacrificeNeededByItemID[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.height = 64;
            Item.width = 64;

            Item.useTime = 15;
            Item.useAnimation = 15;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
            Item.useTurn = true;

            Item.maxStack = 999;
            Item.consumable = true;

            Item.createTile = ModContent.TileType<Tiles.ArlaeriaCrafting>();
            Item.placeStyle = 0;
        }
    }
}
