using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Arlaeria.Items.Tiles;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace Arlaeria.Items
{
    public class Garner : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Arlaeria.hjson file.
        public override void SetStaticDefaults()
        {
            Item.staff[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.damage = 28;
            Item.DamageType = DamageClass.Magic;
            Item.mana = 5;
            Item.useTime = 20;
            Item.useAnimation = 15;
            Item.useStyle = 1;
            Item.knockBack = 2;
            Item.UseSound = SoundID.Item2;
            Item.autoReuse = true;
            Item.shoot = 123;
            //Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 10f;
            Item.noMelee = true;

            Item.height = 24;
            Item.width = 24;

            Item.maxStack = 999;

            Item.rare = 2;
            Item.value = 200000;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Vector2 offset = new Vector2(velocity.X * 15, velocity.Y * 15);
            position = position + offset;
            int projType = ModContent.ProjectileType<Projectiles.Garner_Proj>(); 
            Projectile.NewProjectile(source, position, velocity, projType, damage, knockback, player.whoAmI);
            return false;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(1);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddIngredient<Items.Arlaeic_Energy>(3);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }

    }
}