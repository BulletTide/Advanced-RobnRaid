using Rocket.API.Collections;
using Rocket.Core.Plugins;

namespace RobnRaid
{
    public class RobnRaid : RocketPlugin<Configuration>
    {
        public static RobnRaid Instance;

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList()
                {
                    { "player_not_found","Error: Player not found." },
                    { "rob_translation", "{0} is robbing {1} at {2}!" },
                    { "raid_translation", "{0} is raiding a base at {1}!" },
                    { "raid_assist_translation", "{0} is assisting {1} in a raid!" },
                    { "raid_usage", "Error: Try /raid <location>" },
                    { "rob_usage", "Error: Try /rob <player> <location>" },
                    { "raid_assist_usage", "Error: Try /raidassist <player>" },
                    { "raid_assist_too_far", "Error: You're too far from the player!" },
                    { "rob_over_translation", "{0} has finished robbing {1}!" },
                    { "rob_too_far", "Error: You're too far from the player!" },
                    { "robassist_too_far", "Error: You're too far from the robber!" },
                    { "rob_over_usage", "Error: Try /robover <player>" },
                    { "raid_over_translation", "{0} has finished raiding!" },
                    { "rob_assist_usage", "Error: Try /robassist <player>" },
                    { "rob_assist_translation", "{0} is assisting {1} in a robbery!" }
                };
            }
        }

        protected override void Load()
        {
            Instance = this;

            Rocket.Core.Logging.Logger.Log("RobnRaid by Bullet_Tide & persiafighter has been loaded!");
        }

        protected override void Unload()
        {
            Instance = null;

            Rocket.Core.Logging.Logger.Log("RobnRaid has been unloaded!");
        }
    }
}
