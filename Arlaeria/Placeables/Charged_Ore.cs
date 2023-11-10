using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Arlaeria.Placeables
{
    public class Charged_Ore : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.SortingPriorityMaterials[Type] = 58;
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

            Item.createTile = ModContent.TileType<Items.Tiles.Charged_Ore_TILE>();
            Item.placeStyle = 0;

            Item.rare = 1;
            Item.value = 1000;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(3);
            recipe.AddIngredient(ItemID.IronOre, 5);
            recipe.AddIngredient<Items.Arlaeic_Energy>(1);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();

            Recipe recipe2 = CreateRecipe(3);
            recipe2.AddIngredient(ItemID.LeadOre, 5);
            recipe2.AddIngredient<Items.Arlaeic_Energy>(1);
            recipe2.AddTile(TileID.Furnaces);
            recipe2.Register();
        }

    }
}