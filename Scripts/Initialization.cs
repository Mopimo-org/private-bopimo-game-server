using System.Linq;
using Godot;

namespace Mopimo
{
    public partial class Initialization : Node 
    {
        public override void _Ready()
        {
            GD.Print("Server initialization started.");

            foreach (string arg in OS.GetCmdlineArgs())
            {
                if (arg.Contains('='))
                {
                    string[] keyValue = arg.Split("=");
                    Global.Args[keyValue[0].TrimPrefix("--")] = keyValue[1];
                }
            }

            foreach (string arg in Global.Args.Keys.Select(v => (string)v))
            {
                switch (arg.ToLower())
                {
                    case "port":
                    {
                        if (int.TryParse((string)Global.Args[arg], out int port))
                        {
                            Global.LevelPort = port;
                        }
                        break;
                    }

                    case "level_id":
                    {
                        if (int.TryParse((string)Global.Args[arg], out int level_id))
                        {
                            Global.LevelID = level_id;
                        }
                        break;
                    }
                    
                    default: break;
                }
            }

            GetNode<NetworkManager>("/root/Network/NetworkManager").StartServer();
        }
    }
}
