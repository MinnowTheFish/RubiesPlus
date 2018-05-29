using Terraria.ModLoader;

namespace RubiesPlus
{
	public class RubiesPlus : Mod
	{
		public RubiesPlus()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadBackgrounds = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
		}
	}
}
