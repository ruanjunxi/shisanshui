using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMetro
{
    class Player_History
    {
        public int Combat_Id { get; set; }
        public string Card { get; set; }

        public int Score { get; set; }
        public int Timestamp { get; set; }
    }
    class play_info
    {
        public static int player_ID;
        public static int Combat_Selected_Id;
    }
}
