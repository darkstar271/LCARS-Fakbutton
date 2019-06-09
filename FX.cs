using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
namespace startrek
{
    public static class Fx
    {
        // public  static bool istxtinfo = true;
        // Istxtinfo is a Bool to control a txt box, but can also be used to control other winform properties.
        //
        public static bool Istxtinfo { get; set; } = false; // this is the variable that allows 2 way communication from FX Class and Form1 .
        public static bool ShieldAct { get; set; } = false; // This is part of the Boolen for checking if the ShieldUp has been used
        public static bool IsbtnFireAgain { get; set; } = false; // this is the variable that controls the btnFireAgain, set's weather it is visible or not
        public static bool IsbtnDead { get; set; } = false; // this is the variable that controls the btnDead, set's weather it is visible or not
        public static bool IspicMain { get; set; } = true;// this is the variable that controls the picMain, set's weather it is visible or not

        public static void SoundT1()
        {
            SoundPlayer snPlayer = new SoundPlayer(Resource1._002
            );

            snPlayer.Play();
        }

        public static void SoundT2()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._330);
            sn2Player.Play();


        }

        public static void SoundT3()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._020);
            sn2Player.Play();


        }
        public static void SoundT4()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._072);
            sn2Player.Play();


        }
        public static void SoundT5()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._097);
            sn2Player.Play();


        }
        public static void SoundT6()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._099);
            sn2Player.Play();


        }
        public static void SoundT7()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1.Star_Trek_Red_Alert_Screen);
            sn2Player.Play();


        }

        public static void SoundT8()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._02___Jerry_Goldsmith___Main_Title);
            sn2Player.Play();


        }
        public static void SoundT9()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1.PreyEx21);
            sn2Player.Play();


        }

        public static void SoundT10()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1.KlingonAlert);
            sn2Player.PlayLooping();


        }
        public static void SoundT11()
        {
            SoundPlayer sn2Player = new SoundPlayer(Resource1._101);
            sn2Player.PlayLooping();


        }


    }
}
