using Arlaeria.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Arlaeria.Items
{
    public class Hismark : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.height = 16;
            Item.width = 16;

            Item.maxStack = 999;
            Item.consumable = false;

            Item.value = 20000;

            //Item.createTile = ModContent.TileType<Tiles.Hismark_TILE>();

            Item.rare = 0;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 5);
            recipe.AddIngredient(ItemID.Waterleaf, 2);
            recipe.AddIngredient(ItemID.Daybloom, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
