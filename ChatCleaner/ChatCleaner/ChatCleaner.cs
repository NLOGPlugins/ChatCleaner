
using MiNET;

using MiNET.Plugins;

using MiNET.Plugins.Attributes;

using MiNET.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCleaner
{

    public class ChatCleaner : Plugin
    {

        [Command]
        public void clean(Player player)
        {
            int i = 0;

            do
            {
                player.SendMessage($"{ChatColors.Red}\n");

                ++i;
            }

            while (i < 30);
        }
    }
}