﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
namespace RubiesPlus.Items.TreasureBags
{
    public class TutorialBossBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 9;
            item.expert = true; // Treasure Bags are expert mode only.
            bossBagNPC = mod.NPCType("TutorialBoss"); // The NPC this bag drops from
        }

        public override bool CanRightClick()
        {
            return true; // This bag is opened with right click
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor(); // This will have a chance to spawn the Dev Armour.
            if (Main.rand.Next(3) == 0) // For items that you want to have a chance to drop 
            {
                //player.QuickSpawnItem(mod.ItemType("TutorialBar"));
            }
            player.QuickSpawnItem(ItemID.HallowedBar, 5); // For Items that you want to always drop
        }
    }
}