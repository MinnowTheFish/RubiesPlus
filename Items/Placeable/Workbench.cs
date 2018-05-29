using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RubiesPlus.Items.Placeable
{
    public class Workbench : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("WIP Workbench");
        }


        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.useTime = 14;
            item.useAnimation = 17;
            item.useTurn = true;
            item.autoReuse = true;
            item.useStyle = 1;
            item.createTile = mod.TileType("Workbench");
            item.consumable = true;
        }

        /*public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.DirtBlock, 1);
            r.SetResult(this);
            r.AddRecipe();
        }*/
    }
}