using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace startrek
{
    public class Logic
    {// make 10 Properties to store variables
     //  public bool istxtinfo

        public int butnum { get; set; }
        public string ShieldsUp { get; set; }
        public int randomTwarp { get; set; }
        public int Rndnum { get; set; }
        //public int btnTag { get; set; }
        public int fire { get; set; } = 6;
        // public int num = 0; // sets a variable to be used in the random number generator
        public int Sboost { get; set; } = 2;
        public int fireCountdown()
        {
            return fire - 1;
        }
        // keep working from here
        public int Sdeflect()
        {
            Random random = new Random();
            Rndnum = random.Next(1, 7);
            return Rndnum;
        }






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
                Fx.SoundT2();
            }

        }
        public void WinLose()
        {

            if ((Fx.ShieldAct == true) && (butnum == Rndnum))
            {
                //You have won
                // winning method  here
                Fx.SoundT11();
                return;


            }


            if (butnum == Rndnum)

            // you lose method here
            {
                Fx.SoundT9();
                Fx.Istxtinfo = true; // this is the Boolean that controls a txtbox on the Form.


                return;
            }

            if (butnum != Rndnum)
            {

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

        // Sboost
        public void SboostReset()
        { Sboost = 2; }

        public void Sdeflectreset()
        { Rndnum = 0; }



        public void Allrest()
        {
            SboostReset();
            Sdeflectreset();
        }





    }
}
