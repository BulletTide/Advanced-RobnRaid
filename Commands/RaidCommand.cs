using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;
using UnityEngine;

namespace RobnRaid.Commands
{
    public class RaidCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Player; }
        }

        public string Name
        {
            get { return "raid"; }
        }

        public string Help
        {
            get { return "This is a raiding command."; }
        }

        public string Syntax
        {
            get { return "<location>"; }
        }

        public List<string> Aliases
        {
            get { return new List<string>(); }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if (caller != null)
            {
                UnturnedPlayer player = (UnturnedPlayer)caller;
                if (command.Length == 1)
                {
                    UnturnedChat.Say(RobnRaid.Instance.Translate("raid_translation", player.DisplayName, command[0]), UnturnedChat.GetColorFromName(RobnRaid.Instance.Configuration.Instance.RaidMessageColor, Color.red));
                }
                else
                {
                    UnturnedChat.Say(player, RobnRaid.Instance.Translate("raid_usage"));
                }
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>
                {
                    "raid"
                };
            }
        }
    }
}