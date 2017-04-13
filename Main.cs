using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using UnityEngine;

namespace RobnRaid
{
    public class RobnRaid : RocketPlugin<Configuration>
    {
        public static RobnRaid Instance;
        public Color color;

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList()
                {
                    { "rob_translation", "{0} is robbing {1} at {2}" },
                    { "raid_translation", "{0} is raiding a base at {1}" },
                    { "raid_usage", "Error: Try /raid <location>" },
                    { "rob_usage", "Error: Try /rob <player> <location>" },
                    { "rob_over_translation", "{0} has finished robbing {1}" },
                    { "rob_over_usage", "Error: Try /robover <player>" },
                    { "raid_over_translation", "{0} has finished raiding!" },
                    { "rob_assist_usage", "Error: Try /robassist <robber>" },
                    { "rob_assist_translation", "{0} is assisting {1} in a robbery!" },
                };
            }
        }

        protected override void Load()
        {
            Instance = this;

            color = UnturnedChat.GetColorFromName(Configuration.Instance.Color, Color.green);
            Rocket.Core.Logging.Logger.LogWarning("RobnRaid by Bullet_Tide & persiafighter has been loaded!");
        }

        protected override void Unload()
        {
            Instance = null;

            Rocket.Core.Logging.Logger.LogWarning("RobnRaid has been unloaded!");
        }
    }
}
