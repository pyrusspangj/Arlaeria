using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Arlaeria.Items
{
	public class Elliotic_Condenser : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
		public override void SetStaticDefaults()
		{
            //DisplayName.SetDefault("Elliotic Condenser");
            //Tooltip.SetDefault("Harness the elements.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
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

			Item.createTile = ModContent.TileType<Tiles.Elliotic_Condenser_TILE>();
			Item.placeStyle = 0;

			Item.rare = 1;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}