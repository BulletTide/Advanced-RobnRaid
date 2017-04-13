using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;

namespace RobnRaid.Commands
{
    public class RobOverCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Player; }
        }

        public string Name
        {
            get { return "robover"; }
        }

        public string Help
        {
            get { return "Command to finish robbing!"; }
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
                        UnturnedChat.Say(RobnRaid.Instance.Translate("rob_over_translation", player.DisplayName, Target.DisplayName, command[0]), RobnRaid.Instance.color);
                    }
                }
                else
                {
                    UnturnedChat.Say(player, RobnRaid.Instance.Translate("rob_over_usage"));
                }
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>
                {
                    "robover"
                };
            }
        }
    }
}