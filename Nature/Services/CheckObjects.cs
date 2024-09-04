using Nature.Factory.ClassicPlayer;

namespace Nature.Services
{
    public class CheckObjects
    {     
        public static bool IsNotPlayerNull(ClassicPlayer player)
        {
            if (player != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPlayerExists(ClassicPlayer player)
        {
            if (player.Exists == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
