using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RubiesPlus.Items.Weapons
{
	public class RubySword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ruby Sword");
			Tooltip.SetDefault("A Ruby Encrusted Sword!");
		}
		public override void SetDefaults()
		{
			item.damage = 16;
            item.melee = true;
			item.width = 40;
			item.height = 40;
            item.useTime = 40;
            item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 250000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

        public override void AddRecipes()
        {
            ModRecipe ironRecipe = new ModRecipe(mod);
            ironRecipe.AddIngredient(ItemID.Ruby, 15);
            ironRecipe.AddIngredient(ItemID.Wood, 5);
            ironRecipe.AddIngredient(ItemID.IronBar, 10);
            ironRecipe.AddTile(TileID.Anvils);
            ironRecipe.SetResult(this);
            ironRecipe.AddRecipe();

            ModRecipe leadRecipe = new ModRecipe(mod);
            leadRecipe.AddIngredient(ItemID.Ruby, 15);
            leadRecipe.AddIngredient(ItemID.Wood, 5);
            leadRecipe.AddIngredient(ItemID.LeadBar, 10);
            leadRecipe.AddTile(TileID.Anvils);
            leadRecipe.SetResult(this);
            leadRecipe.AddRecipe();
        }
    }
}
