using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Arlaeria.Items.Tiles;

namespace Arlaeria.Items
{
    public class Molten_Yndicate : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.height = 12;
            Item.width = 12;

            Item.maxStack = 999;

            Item.rare = 1;
            Item.value = 15000;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(1);
            recipe.AddIngredient<Items.Unstable_Yndicate>(2);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }

    }
}