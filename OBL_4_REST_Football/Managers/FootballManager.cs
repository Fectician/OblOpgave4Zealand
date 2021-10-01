using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBL_4_REST_Football.Models;

namespace OBL_4_REST_Football.Managers
{
    public class FootballManager
    {
        //Kode af Nicolas Lauridsen, Datamatiker 3b Zealand Erhvervsakademi.
        private static int _nextId = 1;

        private static List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer {Id = _nextId++, Price = 48, Name = "Carlos", ShirtNumber = 6},
            new FootballPlayer {Id = _nextId++, Price = 44, Name = "Steve", ShirtNumber = 8}

        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }

        public FootballPlayer GetById(int id)
        {
            return Data.Find(footballplayer => footballplayer.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newFootballPlayer)
        {
            newFootballPlayer.Id = _nextId++;
            Data.Add(newFootballPlayer);
            return newFootballPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = Data.Find(player1 => player1.Id == id);
            if (player == null) return null;
            Data.Remove(player);
            return player;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer player = Data.Find(player1 => player1.Id == id);
            if (player == null) return null;
            player.Name = updates.Name;
            player.Price = updates.Price;
            player.ShirtNumber = updates.ShirtNumber;
            return player;
        }
    }
}
