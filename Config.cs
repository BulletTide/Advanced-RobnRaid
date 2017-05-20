using Rocket.API;

namespace RobnRaid
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string PlayerNotFoundColor;
        public string RobMessageColor;
        public string RobOverMessageColor;
        public string RobAssistMessageColor;
        public string RaidMessageColor;
        public string RaidOverMessageColor;
        public uint MaxRobDistance;

        public void LoadDefaults()
        {
            PlayerNotFoundColor = "Yellow";
            RobMessageColor = "Red";
            RobOverMessageColor = "Blue";
            RobAssistMessageColor = "Magenta";
            RaidMessageColor = "Red";
            RaidOverMessageColor = "Blue";
            MaxRobDistance = 5;

        }
    }
}
