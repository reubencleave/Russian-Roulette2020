 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Russian_Roulette
{
    //todo create a random number generator between 1 and 6. Spin event between 1 and 6. Spin Event
    //todo create a counter that only holds 2 numbers so when someone shoots away it decreases by 2 or 1 or 0
    // they can only shoot away 2 times. Put this under a button

    //todo we count down from 6 to the random number on a click Fire Event
    //When the counter == the random number then the most important thing happens!

    //if the person is shooting away from that click, they live.

    //otherwise if the person is not shooting away, they die.

    // rnd          counter         shootaway only 2X
    //3             6               yes
    //3             5               no
    //3             4               no
    //3             3               yes  <== this is the big check we need  you win

    //3             3               no      <== you lose
    public partial class Form1 : Form
    {
        GamePlay gamePlay = new GamePlay();
        int count = 6;
        int shootaway = 2;

        Boolean CanIshootaway = true;
        
        private void btnFire_Click(object sender, EventArgs e)
        {
            //fire code
            count--;
            pbxBowandarrow.Image = Resource1.bow_and_arrow;

            //otherwise you will die

            if (true)//IF the random number == the count number AND you are shooting away you will live.
            {
                //you win
            }

            if (true)//IF the random number == the count number BUT you are not shooting away you will die.
            {
                //you lose
            }



            btnFire.Text = count.ToString();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            //ShootAwayCountdown();
            gamePlay.ShootAwayCountdown();
            int count = 6;
            ShootAwayCountDown = 1;
            pbxBowandarrow.Image = Resource1.leftBowArrow;
        }

        private void ShootAwayCountDown()
        {
            //shootaway button
            shootaway--;

            if (shootaway > 0)
            {
                //boolean you can shoot
                CanIshootaway = true;
            }
            else
            {
                //you can't shoot
                CanIshootaway = false;
            }
        }
        
        
        soundPlayer player = new soundPlayer(Properties.Resources.Gunshot.wav);
        player.Play();
          
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            //Reset Shoot Score
            shootaway Score = 0;


        }
        
            
        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
