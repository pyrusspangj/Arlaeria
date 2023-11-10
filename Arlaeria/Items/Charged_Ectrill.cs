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
    public class Charged_Ectrill : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.damage = 9;
            Item.DamageType = DamageClass.Melee;
            Item.width = 80;
            Item.height = 100;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = 23;
            Item.knockBack = 1;
            Item.value = 3000;
            Item.rare = 1;
            Item.UseSound = SoundID.Item22;
            Item.autoReuse = true;
            Item.pick = 65;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(1);
            recipe.AddIngredient(ItemID.CopperPickaxe, 1);
            recipe.AddIngredient<Charged_Ore>(4);
            recipe.AddIngredient<Charged_Dust>(2);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
