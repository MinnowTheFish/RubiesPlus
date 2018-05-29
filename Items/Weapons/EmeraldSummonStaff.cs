using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RubiesPlus.Items.Weapons
{
    public class EmeraldSummonStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[WIP]Emerald Summon Staff");
            Tooltip.SetDefault("Summons a Flying Emerald!");
        }
        public override void SetDefaults()
        {
            item.noMelee = true;
            item.mana = 20;
            item.channel = true;
            item.magic = true;
            item.shootSpeed = 15;
            //item.shoot = RubiesPlus.ProjectileType("EmeraldSummon");
            item.width = 40;
            item.height = 40;
            item.useTime = 160;
            item.useAnimation = 20;
            item.useStyle = 4;
            item.value = 250000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        /*public override void AddRecipes()
        {
            ModRecipe ironRecipe = new ModRecipe(mod);
            ironRecipe.AddIngredient(ItemID.Emerald, 15);
            ironRecipe.AddIngredient(ItemID.Wood, 20);
            ironRecipe.AddTile(TileID.Anvils);
            ironRecipe.SetResult(this);
            ironRecipe.AddRecipe();
        }*/
    }
}
