
namespace Traffik_Racer_2D
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSolSerit6 = new System.Windows.Forms.Label();
            this.labelSagSerit7 = new System.Windows.Forms.Label();
            this.labelSagSerit6 = new System.Windows.Forms.Label();
            this.labelSolSerit5 = new System.Windows.Forms.Label();
            this.labelSagSerit5 = new System.Windows.Forms.Label();
            this.labelSolSerit4 = new System.Windows.Forms.Label();
            this.labelSagSerit4 = new System.Windows.Forms.Label();
            this.labelSolSerit3 = new System.Windows.Forms.Label();
            this.labelSagSerit3 = new System.Windows.Forms.Label();
            this.labelSolSerit2 = new System.Windows.Forms.Label();
            this.labelSagSerit2 = new System.Windows.Forms.Label();
            this.labelSolSerit1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelRoad = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelSolSerit7 = new System.Windows.Forms.Label();
            this.labelSagSerit1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RedCar = new System.Windows.Forms.PictureBox();
            this.timerSerit = new System.Windows.Forms.Timer(this.components);
            this.timerRandomCar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-9, -23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 892);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(919, -10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 879);
            this.label2.TabIndex = 12;
            // 
            // labelSolSerit6
            // 
            this.labelSolSerit6.BackColor = System.Drawing.Color.White;
            this.labelSolSerit6.Location = new System.Drawing.Point(296, 113);
            this.labelSolSerit6.Name = "labelSolSerit6";
            this.labelSolSerit6.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit6.TabIndex = 3;
            // 
            // labelSagSerit7
            // 
            this.labelSagSerit7.BackColor = System.Drawing.Color.White;
            this.labelSagSerit7.Location = new System.Drawing.Point(611, -69);
            this.labelSagSerit7.Name = "labelSagSerit7";
            this.labelSagSerit7.Size = new System.Drawing.Size(11, 110);
            this.labelSagSerit7.TabIndex = 4;
            // 
            // labelSagSerit6
            // 
            this.labelSagSerit6.BackColor = System.Drawing.Color.White;
            this.labelSagSerit6.Location = new System.Drawing.Point(611, 62);
            this.labelSagSerit6.Name = "labelSagSerit6";
            this.labelSagSerit6.Size = new System.Drawing.Size(11, 110);
            this.labelSagSerit6.TabIndex = 6;
            // 
            // labelSolSerit5
            // 
            this.labelSolSerit5.BackColor = System.Drawing.Color.White;
            this.labelSolSerit5.Location = new System.Drawing.Point(296, 239);
            this.labelSolSerit5.Name = "labelSolSerit5";
            this.labelSolSerit5.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit5.TabIndex = 5;
            // 
            // labelSagSerit5
            // 
            this.labelSagSerit5.BackColor = System.Drawing.Color.White;
            this.labelSagSerit5.Location = new System.Drawing.Point(611, 190);
            this.labelSagSerit5.Name = "labelSagSerit5";
            this.labelSagSerit5.Size = new System.Drawing.Size(11, 110);
            this.labelSagSerit5.TabIndex = 8;
            // 
            // labelSolSerit4
            // 
            this.labelSolSerit4.BackColor = System.Drawing.Color.White;
            this.labelSolSerit4.Location = new System.Drawing.Point(296, 364);
            this.labelSolSerit4.Name = "labelSolSerit4";
            this.labelSolSerit4.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit4.TabIndex = 7;
            // 
            // labelSagSerit4
            // 
            this.labelSagSerit4.BackColor = System.Drawing.Color.White;
            this.labelSagSerit4.Location = new System.Drawing.Point(611, 314);
            this.labelSagSerit4.Name = "labelSagSerit4";
            this.labelSagSerit4.Size = new System.Drawing.Size(11, 110);
            this.labelSagSerit4.TabIndex = 10;
            // 
            // labelSolSerit3
            // 
            this.labelSolSerit3.BackColor = System.Drawing.Color.White;
            this.labelSolSerit3.Location = new System.Drawing.Point(296, 492);
            this.labelSolSerit3.Name = "labelSolSerit3";
            this.labelSolSerit3.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit3.TabIndex = 9;
            // 
            // labelSagSerit3
            // 
            this.labelSagSerit3.BackColor = System.Drawing.Color.White;
            this.labelSagSerit3.Location = new System.Drawing.Point(611, 442);
            this.labelSagSerit3.Name = "labelSagSerit3";
            this.labelSagSerit3.Size = new System.Drawing.Size(11, 110);
            this.labelSagSerit3.TabIndex = 12;
            // 
            // labelSolSerit2
            // 
            this.labelSolSerit2.BackColor = System.Drawing.Color.White;
            this.labelSolSerit2.Location = new System.Drawing.Point(296, 622);
            this.labelSolSerit2.Name = "labelSolSerit2";
            this.labelSolSerit2.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit2.TabIndex = 11;
            // 
            // labelSagSerit2
            // 
            this.labelSagSerit2.BackColor = System.Drawing.Color.White;
            this.labelSagSerit2.Location = new System.Drawing.Point(611, 570);
            this.labelSagSerit2.Name = "labelSagSerit2";
            this.labelSagSerit2.Size = new System.Drawing.Size(11, 110);
            this.labelSagSerit2.TabIndex = 14;
            // 
            // labelSolSerit1
            // 
            this.labelSolSerit1.BackColor = System.Drawing.Color.White;
            this.labelSolSerit1.Location = new System.Drawing.Point(296, 753);
            this.labelSolSerit1.Name = "labelSolSerit1";
            this.labelSolSerit1.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 793);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(916, 76);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(104, 811);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 32);
            this.label16.TabIndex = 17;
            this.label16.Text = "Speed :";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Black;
            this.labelSpeed.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(223, 811);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(100, 32);
            this.labelSpeed.TabIndex = 18;
            this.labelSpeed.Text = "0 km/h";
            this.labelSpeed.Click += new System.EventHandler(this.label17_Click);
            // 
            // labelRoad
            // 
            this.labelRoad.AutoSize = true;
            this.labelRoad.BackColor = System.Drawing.Color.Black;
            this.labelRoad.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoad.ForeColor = System.Drawing.Color.White;
            this.labelRoad.Location = new System.Drawing.Point(485, 811);
            this.labelRoad.Name = "labelRoad";
            this.labelRoad.Size = new System.Drawing.Size(60, 32);
            this.labelRoad.TabIndex = 20;
            this.labelRoad.Text = "0 m";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(381, 811);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 32);
            this.label19.TabIndex = 19;
            this.label19.Text = "Road :";
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.BackColor = System.Drawing.Color.Black;
            this.labelHighScore.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScore.ForeColor = System.Drawing.Color.White;
            this.labelHighScore.Location = new System.Drawing.Point(781, 811);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(60, 32);
            this.labelHighScore.TabIndex = 22;
            this.labelHighScore.Text = "0 m";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(587, 811);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(165, 32);
            this.label21.TabIndex = 21;
            this.label21.Text = "High Score :";
            // 
            // labelSolSerit7
            // 
            this.labelSolSerit7.BackColor = System.Drawing.Color.White;
            this.labelSolSerit7.Location = new System.Drawing.Point(296, -10);
            this.labelSolSerit7.Name = "labelSolSerit7";
            this.labelSolSerit7.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit7.TabIndex = 23;
            // 
            // labelSagSerit1
            // 
            this.labelSagSerit1.BackColor = System.Drawing.Color.White;
            this.labelSagSerit1.Location = new System.Drawing.Point(611, 695);
            this.labelSagSerit1.Name = "labelSagSerit1";
            this.labelSagSerit1.Size = new System.Drawing.Size(11, 110);
            this.labelSagSerit1.TabIndex = 24;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(18, 565);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(36, 23);
            this.axWindowsMediaPlayer1.TabIndex = 25;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Traffik_Racer_2D.Properties.Resources.volumeON;
            this.pictureBox1.Location = new System.Drawing.Point(868, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Traffik_Racer_2D.Properties.Resources.pause;
            this.pictureBox2.Location = new System.Drawing.Point(19, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // RedCar
            // 
            this.RedCar.Image = global::Traffik_Racer_2D.Properties.Resources.car3;
            this.RedCar.Location = new System.Drawing.Point(110, 519);
            this.RedCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedCar.Name = "RedCar";
            this.RedCar.Size = new System.Drawing.Size(120, 167);
            this.RedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedCar.TabIndex = 16;
            this.RedCar.TabStop = false;
            // 
            // timerSerit
            // 
            this.timerSerit.Enabled = true;
            this.timerSerit.Interval = 150;
            this.timerSerit.Tick += new System.EventHandler(this.timerSerit_Tick);
            // 
            // timerRandomCar
            // 
            this.timerRandomCar.Enabled = true;
            this.timerRandomCar.Interval = 150;
            this.timerRandomCar.Tick += new System.EventHandler(this.timerRandomCar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(943, 869);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelSolSerit7);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.labelRoad);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.RedCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSagSerit2);
            this.Controls.Add(this.labelSolSerit1);
            this.Controls.Add(this.labelSagSerit3);
            this.Controls.Add(this.labelSolSerit2);
            this.Controls.Add(this.labelSagSerit4);
            this.Controls.Add(this.labelSolSerit3);
            this.Controls.Add(this.labelSagSerit5);
            this.Controls.Add(this.labelSolSerit4);
            this.Controls.Add(this.labelSagSerit6);
            this.Controls.Add(this.labelSolSerit5);
            this.Controls.Add(this.labelSagSerit7);
            this.Controls.Add(this.labelSolSerit6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSagSerit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Traffic Racer 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSolSerit6;
        private System.Windows.Forms.Label labelSagSerit7;
        private System.Windows.Forms.Label labelSagSerit6;
        private System.Windows.Forms.Label labelSolSerit5;
        private System.Windows.Forms.Label labelSagSerit5;
        private System.Windows.Forms.Label labelSolSerit4;
        private System.Windows.Forms.Label labelSagSerit4;
        private System.Windows.Forms.Label labelSolSerit3;
        private System.Windows.Forms.Label labelSagSerit3;
        private System.Windows.Forms.Label labelSolSerit2;
        private System.Windows.Forms.Label labelSagSerit2;
        private System.Windows.Forms.Label labelSolSerit1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox RedCar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelRoad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelSolSerit7;
        private System.Windows.Forms.Label labelSagSerit1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerSerit;
        private System.Windows.Forms.Timer timerRandomCar;
    }
}

