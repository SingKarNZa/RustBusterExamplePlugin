using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RustBuster2016Server;

namespace RustBusterTestPlugin
{
    /// <summary>
    /// MAKE A SEPARATE PROJECT FOR THIS FILE, THIS IS A FOUGERITE MODULE
    /// </summary>

    public class FougeritePlugin : Fougerite.Module
    {
        public List<string> IDs = new List<string>(); 

        public override string Author
        {
            get { return "DreTaX"; }
        }

        public override string Name
        {
            get { return "FougeritePlugin"; }
        }

        public override Version Version
        {
            get { return new Version("1.0"); }
        }

        public override string Description
        {
            get { return "Wow"; }
        }

        public override void DeInitialize()
        {
            API.OnRustBusterUserMessage -= On_MessageReceived;
        }

        public override void Initialize()
        {
            IDs.Add("655245752526252");
            API.OnRustBusterUserMessage += On_MessageReceived;
        }

        public void On_MessageReceived(API.RustBusterUserAPI user, Message msgc)
        {
            // If the Client Plugin that is sending the message is TestPlugin
            // Ensure to do this ALL the time, or you can mess up other plugin's code.
            if (msgc.PluginSender == "TestPlugin")
            {
                string msg = msgc.MessageByClient;
                string[] split = msg.Split('-');
                // If The client wants to know that it can enable the gui
                if (split[1] == "CanGUI")
                {
                    if (IDs.Contains(split[0]))
                    {
                        // Answer yes
                        msgc.ReturnMessage = "yes";
                    }
                    else
                    {
                        msgc.ReturnMessage = "no";
                    }
                }
            }
        }
    }
}
