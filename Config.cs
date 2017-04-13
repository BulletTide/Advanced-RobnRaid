using Rocket.API;

namespace RobnRaid
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string Color;

        public void LoadDefaults()
        {
            Color = "Green";
        }
    }
}
