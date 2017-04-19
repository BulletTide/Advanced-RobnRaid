using Rocket.API;

namespace RobnRaid
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string RobMessageColor;
        public string RobOverMessageColor;
        public string RobAssistMessageColor;
        public string RaidMessageColor;
        public string RaidOverMessageColor;

        public void LoadDefaults()
        {
            RobMessageColor = "Red";
            RobOverMessageColor = "Blue";
            RobAssistMessageColor = "Magenta";
            RaidMessageColor = "Red";
            RaidOverMessageColor = "Blue";

        }
    }
}
