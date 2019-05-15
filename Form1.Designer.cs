namespace startrek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBow = new System.Windows.Forms.Button();
            this.btnStern = new System.Windows.Forms.Button();
            this.btnPort = new System.Windows.Forms.Button();
            this.btnStarboard = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnShields = new System.Windows.Forms.Button();
            this.bntAlert = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnEngage = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBow
            // 
            this.btnBow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnBow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBow.FlatAppearance.BorderSize = 0;
            this.btnBow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBow.Font = new System.Drawing.Font("LCARS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBow.Location = new System.Drawing.Point(5, 95);
            this.btnBow.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnBow.Name = "btnBow";
            this.btnBow.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnBow.Size = new System.Drawing.Size(148, 51);
            this.btnBow.TabIndex = 1;
            this.btnBow.Tag = "1";
            this.btnBow.Text = "Bow";
            this.btnBow.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBow.UseVisualStyleBackColor = false;
            this.btnBow.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnStern
            // 
            this.btnStern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnStern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStern.Font = new System.Drawing.Font("LCARS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStern.Location = new System.Drawing.Point(5, 149);
            this.btnStern.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStern.Name = "btnStern";
            this.btnStern.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnStern.Size = new System.Drawing.Size(148, 51);
            this.btnStern.TabIndex = 1;
            this.btnStern.Tag = "2";
            this.btnStern.Text = "Stern";
            this.btnStern.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStern.UseVisualStyleBackColor = false;
            this.btnStern.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnPort
            // 
            this.btnPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPort.Font = new System.Drawing.Font("LCARS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPort.Location = new System.Drawing.Point(5, 203);
            this.btnPort.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPort.Name = "btnPort";
            this.btnPort.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnPort.Size = new System.Drawing.Size(148, 51);
            this.btnPort.TabIndex = 2;
            this.btnPort.Tag = "3";
            this.btnPort.Text = "Port";
            this.btnPort.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPort.UseVisualStyleBackColor = false;
            this.btnPort.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnStarboard
            // 
            this.btnStarboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnStarboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStarboard.Font = new System.Drawing.Font("LCARS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarboard.Location = new System.Drawing.Point(5, 257);
            this.btnStarboard.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStarboard.Name = "btnStarboard";
            this.btnStarboard.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnStarboard.Size = new System.Drawing.Size(148, 51);
            this.btnStarboard.TabIndex = 3;
            this.btnStarboard.Tag = "4";
            this.btnStarboard.Text = "Starboard";
            this.btnStarboard.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStarboard.UseVisualStyleBackColor = false;
            this.btnStarboard.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.Font = new System.Drawing.Font("LCARS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.Location = new System.Drawing.Point(5, 310);
            this.btnTop.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTop.Name = "btnTop";
            this.btnTop.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnTop.Size = new System.Drawing.Size(148, 51);
            this.btnTop.TabIndex = 4;
            this.btnTop.Tag = "5";
            this.btnTop.Text = "Top";
            this.btnTop.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottom.Font = new System.Drawing.Font("LCARS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottom.Location = new System.Drawing.Point(5, 363);
            this.btnBottom.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnBottom.Size = new System.Drawing.Size(148, 51);
            this.btnBottom.TabIndex = 5;
            this.btnBottom.Tag = "6";
            this.btnBottom.Text = "Bottom";
            this.btnBottom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBottom.UseVisualStyleBackColor = false;
            this.btnBottom.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnShields
            // 
            this.btnShields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnShields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShields.Font = new System.Drawing.Font("LCARS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShields.Location = new System.Drawing.Point(5, 417);
            this.btnShields.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnShields.Name = "btnShields";
            this.btnShields.Size = new System.Drawing.Size(148, 51);
            this.btnShields.TabIndex = 6;
            this.btnShields.Tag = "7";
            this.btnShields.Text = "ShieldsMax";
            this.btnShields.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnShields.UseVisualStyleBackColor = false;
            this.btnShields.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // bntAlert
            // 
            this.bntAlert.BackgroundImage = global::startrek.Resource1.fed;
            this.bntAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAlert.Location = new System.Drawing.Point(168, 54);
            this.bntAlert.Name = "bntAlert";
            this.bntAlert.Size = new System.Drawing.Size(741, 499);
            this.bntAlert.TabIndex = 7;
            this.bntAlert.UseVisualStyleBackColor = true;
            this.bntAlert.Click += new System.EventHandler(this.BntAlert_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(683, 94);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(185, 189);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.AxWindowsMediaPlayer1_Enter);
            // 
            // btnEngage
            // 
            this.btnEngage.BackgroundImage = global::startrek.Resource1.Enterprise1;
            this.btnEngage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEngage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEngage.FlatAppearance.BorderSize = 0;
            this.btnEngage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngage.Location = new System.Drawing.Point(490, 300);
            this.btnEngage.Name = "btnEngage";
            this.btnEngage.Size = new System.Drawing.Size(397, 168);
            this.btnEngage.TabIndex = 9;
            this.btnEngage.UseVisualStyleBackColor = true;
            this.btnEngage.Visible = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Black;
            this.txtInfo.Font = new System.Drawing.Font("LCARS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.Gold;
            this.txtInfo.Location = new System.Drawing.Point(322, 149);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(211, 134);
            this.txtInfo.TabIndex = 10;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::startrek.Resource1.dsBuffer_bmp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 612);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnEngage);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.bntAlert);
            this.Controls.Add(this.btnShields);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnStarboard);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.btnStern);
            this.Controls.Add(this.btnBow);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBow;
        private System.Windows.Forms.Button btnStern;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Button btnStarboard;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnShields;
        private System.Windows.Forms.Button bntAlert;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnEngage;
        private System.Windows.Forms.TextBox txtInfo;
    }
}

