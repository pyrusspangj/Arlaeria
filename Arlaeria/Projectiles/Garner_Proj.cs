using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.CodeAnalysis;

namespace Arlaeria.Projectiles
{
    public class Garner_Proj : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Magic;
            Projectile.height = 8;
            Projectile.width = 8;
            Projectile.friendly = true;
            Projectile.aiStyle = 0;
            Projectile.penetrate = 2;
            Projectile.timeLeft = 600;
            Projectile.ignoreWater = true;
            Projectile.light = 1;
            Projectile.tileCollide = true;
        }
    }
}
