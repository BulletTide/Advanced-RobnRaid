using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;
using UnityEngine;

namespace RobnRaid.Commands
{
    public class RaidAssistCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Player; }
        }

        public string Name
        {
            get { return "raidassist"; }
        }

        public string Help
        {
            get { return "Command to assisting a raid!"; }
        }

        public string Syntax
        {
            get { return "<player>"; }
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
                    UnturnedPlayer Target = UnturnedPlayer.FromName(command[0]);
                    if (Target != null)
                    {
                        if (Vector3.Distance(Target.Position, player.Position) > RobnRaid.Instance.Configuration.Instance.MaxRaidAssistDistanceInMetres)
                        {
                            UnturnedChat.Say(player, RobnRaid.Instance.Translate("raid_assist_too_far", Target.DisplayName));
                            return;
                        }
                        UnturnedChat.Say(RobnRaid.Instance.Translate("raid_assist_translation", player.DisplayName, Target.DisplayName, command[0]), UnturnedChat.GetColorFromName(RobnRaid.Instance.Configuration.Instance.RobAssistMessageColor, Color.magenta));
                    }
                    else
                    {
                        UnturnedChat.Say(caller, RobnRaid.Instance.Translate("player_not_found"));
                    }
                }
                else
                {
                    UnturnedChat.Say(player, RobnRaid.Instance.Translate("raid_assist_usage"));
                }
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>
                {
                    "raidassist"
                };
            }
        }
    }
}