using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Arlaeria.Items
{
	public class Arla : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("BIG Iron Whacker");
			//Tooltip.SetDefault("It's a BIG hammer... made from a lot of iron...");
		}

		public override void SetDefaults()
		{
			Item.damage = 56;
			Item.DamageType = DamageClass.Melee;
			Item.width = 80;
			Item.height = 1000;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 300000;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}