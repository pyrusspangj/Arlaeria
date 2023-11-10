using Arlaeria.Items.Tiles;
using Arlaeria.Placeables;
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
    public class Charged_Hamaxe : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.damage = 24;
            Item.DamageType = DamageClass.Melee;
            Item.width = 80;
            Item.height = 100;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 1;
            Item.knockBack = 4;
            Item.value = 5500;
            Item.rare = 1;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.axe = 15;
            Item.hammer = 55;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(1);
            recipe.AddIngredient(ItemID.CopperAxe, 1);
            recipe.AddIngredient(ItemID.WoodenHammer, 1);
            recipe.AddIngredient<Charged_Ore>(6);
            recipe.AddIngredient<Charged_Dust>(2);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
