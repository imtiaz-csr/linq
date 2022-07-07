using System;

namespace linq_demo.Models
{
    public class player
    {
        public long PlayerId { get; set; }
        public string PlayerName { get; set; }
        public DateTime Dob { get; set; }
        public string Country { get; set; }

        public player(long playerId, string playerName, DateTime dob, string country)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            Dob = dob;
            Country = country;
        }
    }
}
