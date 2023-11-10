using Arlaeria.Items.Tiles;
using Arlaeria.Placeables;
using Arlaeria.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Arlaeria.Items
{
    public class Arlaeic_Energy : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("BIG Iron Whacker");
            //Tooltip.SetDefault("It's a BIG hammer... made from a lot of iron...");
        }

        public override void SetDefaults()
        { 
            Item.value = 25000;
            Item.maxStack = 999;
            Item.rare = 1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Hismark>(2);
            recipe.AddTile<Elliotic_Condenser_TILE>();
            recipe.Register();
        }
    }
}