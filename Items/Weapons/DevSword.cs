using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RubiesPlus.Items.Weapons
{
    public class DevSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dev Sword");
            Tooltip.SetDefault("If you have this, you shouldn't.");
        }
        public override void SetDefaults()
        {
            item.damage = 1000000;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.scale = 3;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 250000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("DevSword");
            item.shootSpeed = 10f;
        }
    }
}
