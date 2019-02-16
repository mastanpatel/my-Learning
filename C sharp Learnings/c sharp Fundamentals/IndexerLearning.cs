using System;
using System.Collections.Generic;

namespace c_sharp_Fundamentals
{
    //Here we will Learn about Indexers
    //Indexer are very Useful For Accessing Elements OF object using number index or String Index
    class IndexerLearning
    {
    }

    class player
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public int PlayerId { get; set; }

        public List<player> listPlayers;

        public player()
        {
            listPlayers.Add(new player() { Name = "Mastan", Country = "India", PlayerId = 1 });
            listPlayers.Add(new player() { Name = "Yusuf", Country = "India", PlayerId = 2 });
            listPlayers.Add(new player() { Name = "Shafiq", Country = "India", PlayerId = 3 });

        }

        //Creating an Indexer
        public string this [int PId]
        {
            get
            {
                return listPlayers.Find(plr => plr.PlayerId == PId).Name;
            }
            set
            {
                listPlayers.Find(plr => plr.PlayerId == PId).Name = value;
            }

        }

    }

    class TestIndexer
    {
        public static void MainMethod()
        {
            player p = new player();

            Console.WriteLine("PlayerName is : {0}", p[1]);

        }

       
    }
}
