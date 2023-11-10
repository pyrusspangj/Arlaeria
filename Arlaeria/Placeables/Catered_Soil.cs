using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Arlaeria.Placeables
{
    public class Catered_Soil : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.height = 12;
            Item.width = 12;

            Item.useTime = 10;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
            Item.useTurn = true;

            Item.maxStack = 999;
            Item.consumable = true;

            Item.createTile = ModContent.TileType<Items.Tiles.Catered_Soil_TILE>();
            Item.placeStyle = 0;

            Item.rare = 0;
            Item.value = 100;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(2);
            recipe.AddIngredient(ItemID.DirtBlock, 4);
            recipe.AddIngredient(ItemID.ClayBlock, 1);
            recipe.AddIngredient(ItemID.PurificationPowder, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

        }

    }
}