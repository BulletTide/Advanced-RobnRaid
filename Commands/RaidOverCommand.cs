using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;
using System;

namespace RobnRaid.Commands
{
    public class RaidOverCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Player; }
        }

        public string Name
        {
            get { return "raidover"; }
        }

        public string Help
        {
            get { return "Command to finish raiding!"; }
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
                if (command.Length == 0)
                {
                    UnturnedChat.Say(RobnRaid.Instance.Translate("raid_over_translation", player.DisplayName), RobnRaid.Instance.color);
                }
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>
                {
                    "raidover"
                };
            }
        }

        public string Syntax
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}