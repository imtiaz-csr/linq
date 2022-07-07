using System;
using System.Collections.Generic;

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

        public List<player> listOfPlayer = new List<player>()
        {
            new player(3,"Sakib Al Hasan", DateTime.Parse("1987/05/12"),"Bangladesh"),
            new player(4,"Maria Sharapova", DateTime.Parse("1989/03/18"),"Russia"),
            new player(5,"Anna Kournikova", DateTime.Parse("1992/01/01"),"Russia"),
            new player(6,"Christiano Ronaldo", DateTime.Parse("1994/12/05"),"Portugal")
        };
    }
}
