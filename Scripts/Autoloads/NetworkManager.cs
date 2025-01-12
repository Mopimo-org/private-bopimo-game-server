using Godot;

namespace Mopimo
{
    public partial class NetworkManager : Node
    {
        ENetMultiplayerPeer RelatedPeer = new();

        public Error StartServer() =>
            RelatedPeer.CreateServer(Global.LevelPort, 32);
        
        
    }
}