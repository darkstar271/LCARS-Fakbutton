using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
//using System.Timers;
namespace startrek
{




    public class Logic


    {// make 10 Properties to store variables
     //  public bool istxtinfo
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        // Form1 myForm1 = new Form1();
        // public PictureBox PicMain { get; set; }
        public Logic()

        {
            myTimer.Tick += new System.EventHandler(myTimer_Tick);

        }

        private void Time()
        {

            //Set the timer tick interval time in milliseconds
            myTimer.Interval = 3000;
            //Start timer
            myTimer.Start();
            Fx.IsbtnFireAgain = true;
            // Fx.IsbtnDead = true;



        }
        //Timer tick event handler
        private void myTimer_Tick(object sender, System.EventArgs e)
        {
            // this.label1.Text = "Successful";
            // pictureBox5.Visible = false;
            //Stop the timer - if required
            // Fx.IsbtnDead = false;
            Fx.IsbtnFireAgain = false;

            myTimer.Stop();

        }





        public int butnum { get; set; }
        public string ShieldsUp { get; set; }
        public int randomTwarp { get; set; }
        public int Rndnum { get; set; }
        //public int btnTag { get; set; }
        public int fire { get; set; } = 6;
        // public int num = 0; // sets a variable to be used in the random number generator

        // the win score of the Enterprise and Klingons
        public int KlingonScore { get; set; } = 5;
        public int EnterpriseScore { get; set; } = 10;

        public int fireCountdown()
        {
            return fire - 1;
        }
        //// shield countdown method
        //public int ShieldCountDown()
        //{
        //    return Fx.Sboost - 1;
        //}
        // keep working from here
        // Random number generator
        public int Sdeflect()
        {
            Random random = new Random();
            Rndnum = random.Next(1, 7);
            return Rndnum;

        }

        //public void ImageCh()
        //{
        //    PicMain.Image = Resource1.entex; // this changes the PicMain picture to BOPEX
        //    PicMain.SizeMode = PictureBoxSizeMode.StretchImage;// this sets the size to stretchImage


        //}




        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties




        public int TranWarp()
        {
            Random Trandom = new Random();
            randomTwarp = Trandom.Next(0, 11);
            return randomTwarp;

        }

        public void Winshield()

        {
            if (Fx.ShieldAct == true)
            {
                Fx.SoundT2(); // update complete 
            }

        }
        #region WinLose
        // This is the Winlose method it is mostly three "IF" statements,this is the heart of the program.
        public void WinLose()
        {

            if ((Fx.ShieldAct == true) && (butnum == Rndnum))
            {
                //You have won
                // winning method  here
                Fx.IspicMain = false;
                Fx.IsbtnWin = true;
                Fx.Sound12();
                return;


            }


            if (butnum == Rndnum)

            // you lose method here
            {
                Fx.SoundT9();
                // ImageCh();
                Fx.IspicMain = false;
                Fx.IsbtnDead = true;

                // Fx.Istxtinfo = true; // this is the Boolean that controls a txtbox on the Form.


                return;
            }

            if (butnum != Rndnum)
            {
                // Fx.IsbtnFireAgain = true;
                //Time();




                // make refire method


            }
            // method here keep firing

            //message you missed fire again



            //// lose if statement
            //if (Sboost == 0 && fire > 0)

            //{
            //    Fx.SoundT9();

            //    // do stuff


            //}

            //if // use shield is True and Fire/Butnum == num you Win
            //{
            //    Fx.SoundT7();
            //    //return;
            //}


        }
        #endregion

        //public int Test()
        //{
        //The conditional logical OR operator || also computes the logical OR of its operands, but doesn't evaluate the second operand if the first operand evaluates to true.
        //    if (mySaw.Block == 0 || (mySaw.Block == 0 && mySaw.UserSpins > 0))
        //    {
        //        SoundPlayer snPlayer = new SoundPlayer(Resources.blood_2);
        //        snPlayer.Play();
        //        MessageBox.Show("you're dead");
        //        ButtonOff();
        //        return;
        //    }

        //    if (mySaw.UserSpins == mySaw.Rnd)

        //    {

        //        SoundPlayer snPlayer = new SoundPlayer(Resources.Gun_Shot2);
        //        snPlayer.Play();
        //        MessageBox.Show("your dead cat");
        //        ButtonOff();
        //        return;
        //    }



        //}

        //// Sboost
        //public void SboostReset()
        //{ Sboost = 2; }

        //public void Sdeflectreset()
        //{ Rndnum = 0; }



        //public void Allrest()
        //{
        //    SboostReset();
        //    Sdeflectreset();
        //}





    }
}
