using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayattheRaces
{
    public partial class Form1 : Form
    {

        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Random MyRandomizer = new Random();


        public Form1()
        {
            InitializeComponent();




            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyLabel = joeBetLabel,
                MyRadioButton = JoeRadioButton,
                MyBet = new Bet() { Amount = 0, Bettor = GuyArray[0], Dog = 0 }

            };



            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyLabel = bobBetLabel,
                MyRadioButton = bobRadioButton,
                MyBet = new Bet() { Amount = 0, Bettor = GuyArray[1], Dog = 0 }

            };


            GuyArray[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyLabel = alBetLabel,
                MyRadioButton = alRadioButton,
                MyBet = new Bet() { Amount = 0, Bettor = GuyArray[2], Dog = 0 }
            };




            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width,
                Randomizer = MyRandomizer
            };

            minimumBetLabel.Text = "Minimum bet: " + bucksToBet.Minimum + " buks";

            for (int i = 0; i < GuyArray.Length; i++)
            {


                GuyArray[i].ClearBet();
                GuyArray[i].UpdateLabels();
               

            }



        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < GreyhoundArray.Length; i++)
            {

                
                if (GreyhoundArray[i].Run())
                {
                   
                    timer1.Stop();
                    int winner = i + 1;
                    
                    MessageBox.Show("Dog #" + winner + " won the race");
                    GuyArray[0].Collect(winner);
                    GuyArray[1].Collect(winner);
                    GuyArray[2].Collect(winner);

                    for (int j = 0; j < GreyhoundArray.Length; j++)
                    {
                        GreyhoundArray[j].TakeStartingPosition();
                    }
                    groupBox1.Enabled = true;
                     
                }
                

               
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (JoeRadioButton.Checked)
            {

                if (GuyArray[0].PlaceBet((int)bucksToBet.Value, (int)dogToBet.Value))
                {
                                          
                    GuyArray[0].UpdateLabels();
                }
                
             } 
            
            if (bobRadioButton.Checked)
            {

                if (GuyArray[1].PlaceBet((int)bucksToBet.Value, (int)dogToBet.Value))
                {
                    GuyArray[1].UpdateLabels();
                }
            } 
            
            if (alRadioButton.Checked)
            {

                if (GuyArray[2].PlaceBet((int)bucksToBet.Value, (int)dogToBet.Value))
                {
                    GuyArray[2].UpdateLabels();
                }

            }
            
        }

    }
}
