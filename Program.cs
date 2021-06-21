using System;
using static System.Console;
namespace TestSoccerPlayer
{
    class TestSoccerPlayer
    {
        static void Main(string[] args)
        {
            WriteLine("Hello SoccerPlayer World!");
            SoccerPlayer myFav = new SoccerPlayer();
            myFav.Name = "Messi";
            myFav.JerseyNumber = 10;
            myFav.Goals = 750;
            myFav.Assist = 100;

            WriteLine($"My Favorite player is {myFav.Name}, with jersey number { myFav.JerseyNumber}, who has scored { myFav.Goals} and {myFav.Assist } assists.");
        }
    }

    class SoccerPlayer
    {
        public string Name { get; set; }
        public int JerseyNumber { get; set; }
        public int Goals { get; set; }
        public int Assist { get; set; }
    }
 
}
