using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using [System.ComponentModel.TypeConverter(typeof(System.Windows.Forms.OpacityConverter))];

namespace _00_Challenges.Maze_Problem
{
    //Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,InvincibleBirdHunter,EveningGrosbeak,GreaterPrairieChicken,VulnerableBirdHunter,VulnerableBirdHunter,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,IcelandGull,CrestedIbis,GreatKiskudee,InvincibleBirdHunter,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,RedCrossbill,Red-neckedPhalarope,InvincibleBirdHunter,VulnerableBirdHunter,Orange-belliedParrot,InvincibleBirdHunter,Bird,Bird,Bird,Bird,Bird,VulnerableBirdHunter

    //****purpose is to output results of a simulated game, points, lives, etc****

    //Imagine you're watching someone play this Drofsnar game and keeping track of everything they interact with.
    //Once the game is over, you're left with a collection of interactions.
    //Your task is now to go through that list of interactions and tally the score and remaining lives.
    //Your code should read from the file and manage the specific collision with each entity by scoring points and lives.
    //This means you'll need to be able to check what the next item Drofsnar interacts with and evaluate the appropriate value.


    //Object Oriented Programming

    //Game Rules

    // Drofsnar, our Bird-Man hero, moves around the room, and he saves all of the birds he meets.
    // Four Bird Hunters roam the room, trying to catch Drofsnar.
    // If a Bird Hunter chomps Drofsnar, a life is lost.
    //When all lives have been lost, the game ends.
    //In each corner of a room there is a "Stopper" that provides Drofsnar with the temporary ability to stave off the enemies.
    //If Drofsnar gets the Stopper, the Bird Hunters become vulnerable.
    //Drofsnar can get extra points by defeating the Bird Hunters while they are vulnerable, but the Bird Hunters come back after the Stopper wears off.
    //The first Bird Hunter is worth 200 points and each additional Bird Hunter eaten is worth double the number of points (from 200 to 1600 per bird hunter eaten).  
    // Drofsnar can get extra points as "rare birds" appear.
    //The number of points given for each rare bird depends on the bird type.
    //When the Drofsnar reaches 10000 points, he gets an additional life.


    //Scoring System:

    //    Bird: 10 points each
    //    Crested Ibis: 100 points
    //    Great Kiskudee: 300 points
    //    Red Crossbill: 500 points
    //    Red-necked Phalarope: 700 points
    //    Evening Grosbeak: 1000 points
    //    Greater Prairie Chicken: 2000 points
    //    Iceland Gull: 3000 points
    //    Orange-Bellied Parrot: 5000 points
    //    Vulnerable Bird Hunters: 
    //    #1 in succession: 200 points 
    //    #2 in succession: 400 points
    //    #3 in succession: 800 points
    //    #4 in succession: 1600 points  

    //Vulnerable bird hunter succession does not need to be a continuous sequence, meaning that it could be spaced out by other entities.

    //Assume that Drofsnar starts the game with:
    //5000 points  
    //3 lives
    //At the end of the game print out the total points and total remaining lives.


    //this is a simple math problem ya dingus
    //calculate lives lost / points gained etc
    //should output loops to consoleUI

    public partial class IDontKnowWhatImDoing : MazeUI
    {
        public void IDontKnowWhatImDoing1()
        {
            this.BackgroundImage = Properties.Resources.im;
            InitializeComponent();
            var timer = new Timer();
            //change the background image every second  
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //add image in list from resource file.  
            //List<PictureBox> lisimage = new List<Bitmap>();
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.im);
            lisimage.Add(Properties.Resources.rite);
            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            this.BackgroundImage = lisimage[indexbackimage];
        }
    }
}
