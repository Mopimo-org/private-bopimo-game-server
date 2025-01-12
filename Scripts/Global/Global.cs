namespace Mopimo
{
    public class Global 
    {
        public const bool IsTesting = true;
        public static int LevelPort = 30302;
        public static int LevelID = 1; // just "emulating"
        public static Godot.Collections.Dictionary Args = []; // parsed from OS.GetCmdlineArgs()
    }
}
