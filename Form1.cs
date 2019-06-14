using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.Threading;
using System.Timers;
using startrek.Properties;
// link the unittestST to the project
// LCARS font added to winform, this is the font used on Startrek movies and tv shows, it's the computer interface (Library Computer Access/Retrieval System)

//https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.tag?view=netframework-4.8
//Any type derived from the Object class can be assigned to this property. If the Tag property is set through the Windows Forms designer, only text can be assigned. 



namespace startrek
{

    public partial class Form1 : Form

    {
        #region RoundRect method 
        // System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        // RoundRect method this makes the win-form have round edges
        Logic myLogic = new Logic();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse



        );

        #endregion

        #region constructor & win-form roundEdge form
        public Form1()
        {




            InitializeComponent();
            // Fx.istxtinfo = txtInfo.Visible;
            txtInfo.Visible = false;
            txtEnterprise.Text += "  " + myLogic.EnterpriseScore.ToString();
            txtKlingons.Text += "  " + myLogic.KlingonScore.ToString();
            // btnShields.Text += "  " + Fx.Sboost.ToString();
            // txtInfo.Visible = Fx.Istxtinfo;
            this.FormBorderStyle = FormBorderStyle.None; Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            // this set's the media player to not show controls, it has to be set here as a defult.
            // axWindowsMediaPlayer1.uiMode = "none";
            //- Fx.SoundT7();

            //  picMain = myLogic.PicMain;
        }
        #endregion

        #region fake button method
        private void BtnEnter_Click(object sender, EventArgs e)
        {

            // count down the shiledboost. If shieldboost is less than 0 you die


            //1 set the shield to true
            //chekc if the rnd == number clicked

            //if yes WIN!

            Button fakeLcars = (Button)sender;
            ShieldsUp(fakeLcars.Name);
            // Fx.IsbtnFireAgain;
            btnFireAgain.Visible = Fx.IsbtnFireAgain;
            btnDead.Visible = Fx.IsbtnDead;
            btnWin.Visible = Fx.IsbtnWin;
            // picMain.Visible = Fx.IspicMain;

            // picMain = myLogic.PicMain;
            //  txtInfo.Visible = Fx.Istxtinfo;// // this links the variable "Istxtinfo" to the text box "txtInfo" and allows one to influence the other. 



            //if (myLogic.btnTag == myLogic.num)
            //{

            //}
            //// Fx.SoundT1();
        }
        #endregion





        // https://blog.submain.com/c-switch-statement-beware/

        //Button btnumber = (Button)sender;
        //ShieldsUp(btnumber.Tag);

        // int tag = (sender as button).Tag
        // int tag = (Button)sender.Tag;
        // public new object Tag { get; set; }
        #region Button master switch
        public void ShieldsUp(string shieldsDir)
        {

            {
                switch (shieldsDir)
                {
                    case "btnBow":

                        myLogic.butnum = 1;
                        //  MessageBox.Show(myLogic.butnum.ToString());
                        myLogic.WinLose();
                        //txtInfo.Visible = Fx.Istxtinfo;
                        // myLogic.btnTag 
                        //Fx.SoundT2();
                        // this just tests the random gen in Logic.cs and prints the value to screen

                        myLogic.ShieldsUp = "Bow";
                        btnBow.Enabled = false;
                        break;
                    case "btnStern":
                        myLogic.butnum = 2;
                        //MessageBox.Show(myLogic.butnum.ToString());
                        myLogic.WinLose();
                        //txtInfo.Visible = Fx.Istxtinfo;
                        //  Fx.SoundT1();
                        myLogic.ShieldsUp = "Stern";
                        btnStern.Enabled = false;
                        break;
                    case "btnPort":
                        myLogic.butnum = 3;
                        //MessageBox.Show(myLogic.butnum.ToString());
                        myLogic.WinLose();
                        //txtInfo.Visible = Fx.Istxtinfo;
                        // Fx.SoundT3();
                        myLogic.ShieldsUp = "Port";
                        btnPort.Enabled = false;
                        break;
                    case "btnStarboard":
                        myLogic.butnum = 4;
                        //MessageBox.Show(myLogic.butnum.ToString());
                        myLogic.WinLose();
                        // txtInfo.Visible = Fx.Istxtinfo;
                        // Fx.SoundT4();
                        myLogic.ShieldsUp = "Starboard";
                        btnStarboard.Enabled = false;
                        break;
                    case "btnTop":
                        myLogic.butnum = 5;
                        //MessageBox.Show(myLogic.butnum.ToString());
                        myLogic.WinLose();
                        //txtInfo.Visible = Fx.Istxtinfo;
                        // Fx.SoundT5();
                        //  myLogic.ShieldsUp = "Top";
                        btnTop.Enabled = false;
                        break;
                    case "btnBottom":
                        myLogic.butnum = 6;
                        //MessageBox.Show(myLogic.butnum.ToString());
                        myLogic.WinLose();
                        //txtInfo.Visible = Fx.Istxtinfo;
                        // Fx.SoundT6();
                        //  myLogic.ShieldsUp = "Bottom";
                        btnBottom.Enabled = false;
                        break;
                    case "btnShields":

                        // Fx.ShieldAct = true;
                        // int Shield = ShieldCountDown();

                        Sboost -= 1;

                        //// shield countdown method
                        //public int ShieldCountDown()
                        //{
                        //    return Sboost - 1;
                        //}





                        MessageBox.Show(Sboost.ToString());

                        //  btnShields.Text = "  " + shoot.ToString();
                        btnShields.Text = "ShieldMax  " + Sboost.ToString();
                        //  myLogic.Winshield();

                        // myLogic.ShieldsUp = "Shields";
                        break;
                    //axWindowsMediaPlayer1.URL = @"G:\Visual Studio 2019 Files\startrek\Resources\PreyEx2.avi";

                    //axWindowsMediaPlayer1.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                    //    "PreyEx2.avi");

                    // axWindowsMediaPlayer1.URL = "Resources\\PreyEx2.avi";
                    // axWindowsMediaPlayer1.Ctlcontrols.play();

                    //axWindowsMediaPlayer1.(Resource1.PreyEx2);
                    //SoundPlayer sn2Player = new SoundPlayer(Resource1._330);
                    //sn2Player.Play();

                    // Fx.SoundT7();

                    case "btnEngage":

                        btnEngage.Visible = false;
                        Fx.SoundT7();




                        Fx.SoundT10();
                        btnInfo.Visible = true;
                        //txtInfo.Visible = true;
                        // Thread.Sleep(3000);
                        // Fx.SoundT1();
                        myLogic.ShieldsUp = "";
                        break;

                    case "bntAlert":
                        bntAlert.Visible = false;
                        Fx.SoundT8();

                        btnEngage.Visible = true;
                        Thread.Sleep(10000);
                        Thread.Sleep(0);

                        break;

                    case "btnInfo":

                        // Fx.SoundT3();
                        myLogic.Sdeflect(); // this is the Random number generator
                        btnInfo.Visible = false;
                        picMain.Visible = true;
                        //Thread.Sleep(10000);
                        //Thread.Sleep(0);
                        //picMain.Image = Resource1.BOPEX; // this changes the PicMain picture to BOPEX
                        //picMain.SizeMode = PictureBoxSizeMode.StretchImage;// this sets the size to stretchImage
                        // send to Winlose  method 
                        break;

                    case "btnFireAgain":

                        //Fx.ShieldAct = true;
                        //myLogic.Winshield();
                        // myLogic.ShieldsUp = "Shields";
                        break;

                    case "btnReplay":

                        // reset all methods and restart game

                        break;

                    case "btnDead":


                        break;

                }

                Text = myLogic.ShieldsUp;
            }


        }
        #endregion
        //public void ImageCh()
        //{
        //    picMain.Image = Resource1.entex; // this changes the PicMain picture to BOPEX
        //    picMain.SizeMode = PictureBoxSizeMode.StretchImage;// this sets the size to stretchImage


        //}
        //picMain.Image = Resource1.BOPEX; // this changes the PicMain picture to BOPEX
        //picMain.SizeMode = PictureBoxSizeMode.StretchImage;// this sets the size to stretchImage

        #region BntAlert_Click
        public void BntAlert_Click(object sender, EventArgs e)
        {               //---------//
                        // Keep this code

            //bntAlert.Visible = false;
            //Fx.SoundT8();

            //btnEngage.Visible = true;
            //Thread.Sleep(10000);
            //Thread.Sleep(0);





            // txtInfo.Visible = true;
            //Thread.Sleep(5000);
            // time delay
            // next picture showing instructions 
            // Keep this code
            //---------//


            // axWindowsMediaPlayer1.URL = @"G:\Doubleback.mp4";

            // Keep this code
            //---------//
            //axWindowsMediaPlayer1.URL = "Resources\\PreyEx2.avi";
            // axWindowsMediaPlayer1.URL = @"G:\Visual Studio 2019 Files\startrek\Resources\PreyEx2.avi";
            // Keep this code
            //---------//


            // G:\Visual Studio 2019 Files\startrek\Resources
            //BtnVisBol();
            //Fx.SoundT6();
        }
        #endregion
        private void BtnVisBol()
        {
            bntAlert.Visible = false;


        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        //private static void SoundT1()
        //{
        //    SoundPlayer snPlayer = new SoundPlayer(Resource1._002
        //    );

        //    snPlayer.Play();
        //}


        private void cat()

        {

        }





        #region Timetest

        //

        //    //Set the timer tick event, this must be put in the constructor
        //    myTimer.Tick += new System.EventHandler(myTimer_Tick);

        //private void Button1_Click_1(object sender, EventArgs e)
        //{
        //    //Set the timer tick interval time in milliseconds
        //    myTimer.Interval = 1000;
        //    //Start timer
        //    myTimer.Start();
        //}
        ////Timer tick event handler
        //private void myTimer_Tick(object sender, System.EventArgs e)
        //{
        //    this.label1.Text = "Successful";
        //    //Stop the timer - if required
        //    myTimer.Stop();
        //}








        #endregion

        private void TxtKlingons_TextChanged(object sender, EventArgs e)
        {

            //  txtKlingons.Text += "  " + myLogic.KlingonScore.ToString();
        }

        private void TxtEnterprise_TextChanged(object sender, EventArgs e)
        {
            // txtEnterprise.Text += "  " + myLogic.EnterpriseScore.ToString();
        }

        public int Sboost { get; set; } = 10;


        // shield countdown method
        public int ShieldCountDown()
        {
            return Sboost - 1;
        }


    }
}
