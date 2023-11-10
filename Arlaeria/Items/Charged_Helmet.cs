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
    [AutoloadEquip(EquipType.Head)]
    public class Charged_Helmet : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.

        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.height = 16;
            Item.width = 16;

            Item.maxStack = 1;
            Item.consumable = false;

            Item.value = 500;

            Item.defense = 7;

            Item.rare = 0;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.25f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(1);
            recipe.AddIngredient<Unstable_Yndicate>(1);
            recipe.AddIngredient<Charged_Ore>(9);
            recipe.AddIngredient<Charged_Dust>(1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
