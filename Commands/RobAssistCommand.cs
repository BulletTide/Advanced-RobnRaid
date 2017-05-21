using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;
using UnityEngine;

namespace RobnRaid.Commands
{
    public class RobAssistCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Player; }
        }

        public string Name
        {
            get { return "robassist"; }
        }

        public string Help
        {
            get { return "Command to assisting a robbery!"; }
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
                        if (UnityEngine.Vector3.Distance(Target.Position, player.Position) > RobnRaid.Instance.Configuration.Instance.MaxRobAssistDistanceInMetres)
                        {
                            UnturnedChat.Say(player, RobnRaid.Instance.Translate("robassist_too_far", Target.DisplayName));
                            return;
                        }
                        UnturnedChat.Say(RobnRaid.Instance.Translate("rob_assist_translation", player.DisplayName, Target.DisplayName, command[0]), UnturnedChat.GetColorFromName(RobnRaid.Instance.Configuration.Instance.RobAssistMessageColor, Color.magenta));
                    }
                    else
                    {
                        UnturnedChat.Say(caller, RobnRaid.Instance.Translate("player_not_found"));
                    }
                }
                else
                {
                    UnturnedChat.Say(player, RobnRaid.Instance.Translate("rob_assist_usage"));
                }
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>
                {
                    "robassist"
                };
            }
        }
    }
}