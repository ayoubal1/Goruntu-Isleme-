
namespace odev
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.texmed = new System.Windows.Forms.TextBox();
            this.trackaz = new System.Windows.Forms.TrackBar();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackco = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackayna = new System.Windows.Forms.TrackBar();
            this.labelaz = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelco = new System.Windows.Forms.Label();
            this.labelayna = new System.Windows.Forms.Label();
            this.labelkont = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackkont = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackayna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackkont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(1098, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "NEGATİFİN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(1098, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "GRİ RESİM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(927, 187);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "PARLAKLIĞINI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Location = new System.Drawing.Point(176, 370);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(150, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "dosya aç";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button9.Location = new System.Drawing.Point(927, 351);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 60);
            this.button9.TabIndex = 18;
            this.button9.Text = "KÜÇÜLTME";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Linen;
            this.button10.Location = new System.Drawing.Point(576, 370);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 60);
            this.button10.TabIndex = 19;
            this.button10.Text = "ResmiKaydet";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button11.Location = new System.Drawing.Point(1098, 187);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(150, 60);
            this.button11.TabIndex = 20;
            this.button11.Text = "NETLEŞTİRME";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button12.Location = new System.Drawing.Point(1098, 351);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(150, 60);
            this.button12.TabIndex = 21;
            this.button12.Text = "DÖNÜŞTÜRÜLEN";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button13.Location = new System.Drawing.Point(1098, 727);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(150, 50);
            this.button13.TabIndex = 22;
            this.button13.Text = "MEDİAN";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // texmed
            // 
            this.texmed.Location = new System.Drawing.Point(1030, 746);
            this.texmed.Margin = new System.Windows.Forms.Padding(4);
            this.texmed.Name = "texmed";
            this.texmed.Size = new System.Drawing.Size(49, 22);
            this.texmed.TabIndex = 23;
            this.texmed.TextChanged += new System.EventHandler(this.texmed_TextChanged);
            // 
            // trackaz
            // 
            this.trackaz.Location = new System.Drawing.Point(128, 514);
            this.trackaz.Maximum = 250;
            this.trackaz.Name = "trackaz";
            this.trackaz.Size = new System.Drawing.Size(198, 56);
            this.trackaz.TabIndex = 25;
            this.trackaz.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button15.Location = new System.Drawing.Point(927, 431);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(150, 60);
            this.button15.TabIndex = 28;
            this.button15.Text = "HİSTOGRAM";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DodgerBlue;
            this.button16.Location = new System.Drawing.Point(927, 269);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(150, 60);
            this.button16.TabIndex = 30;
            this.button16.Text = "SOBEL";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button17.Location = new System.Drawing.Point(1098, 431);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(150, 60);
            this.button17.TabIndex = 31;
            this.button17.Text = "PREWİTT";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button18.Location = new System.Drawing.Point(927, 22);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(150, 60);
            this.button18.TabIndex = 32;
            this.button18.Text = "TERS ÇEVİRME";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "parlaklık azaltma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 629);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "parlaklık çokatma";
            // 
            // trackco
            // 
            this.trackco.Location = new System.Drawing.Point(122, 622);
            this.trackco.Maximum = 250;
            this.trackco.Name = "trackco";
            this.trackco.Size = new System.Drawing.Size(198, 56);
            this.trackco.TabIndex = 34;
            this.trackco.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Dondurme";
            // 
            // trackayna
            // 
            this.trackayna.Location = new System.Drawing.Point(439, 514);
            this.trackayna.Maximum = 250;
            this.trackayna.Minimum = -255;
            this.trackayna.Name = "trackayna";
            this.trackayna.Size = new System.Drawing.Size(198, 56);
            this.trackayna.TabIndex = 36;
            this.trackayna.Scroll += new System.EventHandler(this.trackayna_Scroll);
            // 
            // labelaz
            // 
            this.labelaz.AutoSize = true;
            this.labelaz.Location = new System.Drawing.Point(332, 528);
            this.labelaz.Name = "labelaz";
            this.labelaz.Size = new System.Drawing.Size(0, 16);
            this.labelaz.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 39;
            // 
            // labelco
            // 
            this.labelco.AutoSize = true;
            this.labelco.Location = new System.Drawing.Point(326, 629);
            this.labelco.Name = "labelco";
            this.labelco.Size = new System.Drawing.Size(0, 16);
            this.labelco.TabIndex = 40;
            // 
            // labelayna
            // 
            this.labelayna.AutoSize = true;
            this.labelayna.Location = new System.Drawing.Point(643, 528);
            this.labelayna.Name = "labelayna";
            this.labelayna.Size = new System.Drawing.Size(0, 16);
            this.labelayna.TabIndex = 41;
            // 
            // labelkont
            // 
            this.labelkont.AutoSize = true;
            this.labelkont.Location = new System.Drawing.Point(643, 629);
            this.labelkont.Name = "labelkont";
            this.labelkont.Size = new System.Drawing.Size(0, 16);
            this.labelkont.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 644);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Kontrast";
            // 
            // trackkont
            // 
            this.trackkont.Location = new System.Drawing.Point(439, 626);
            this.trackkont.Maximum = 250;
            this.trackkont.Minimum = -255;
            this.trackkont.Name = "trackkont";
            this.trackkont.Size = new System.Drawing.Size(198, 56);
            this.trackkont.TabIndex = 42;
            this.trackkont.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(927, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 60);
            this.button6.TabIndex = 48;
            this.button6.Text = "AYANLAMA";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(1098, 510);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 60);
            this.button4.TabIndex = 49;
            this.button4.Text = "KARŞITLIK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_3);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cyan;
            this.button7.Location = new System.Drawing.Point(929, 510);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 60);
            this.button7.TabIndex = 52;
            this.button7.Text = "PERSPEKTİF";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button8.Location = new System.Drawing.Point(1098, 269);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 60);
            this.button8.TabIndex = 53;
            this.button8.Text = "BÜYÜKLETME";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "R";
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(715, 528);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Minimum = -255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(184, 56);
            this.trackBarR.TabIndex = 55;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(715, 622);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Minimum = -255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(184, 56);
            this.trackBarG.TabIndex = 57;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 626);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "G";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(899, 542);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(0, 16);
            this.labelR.TabIndex = 58;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(899, 641);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(0, 16);
            this.labelG.TabIndex = 59;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(899, 459);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(0, 16);
            this.labelB.TabIndex = 63;
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(715, 445);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Minimum = -255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(184, 56);
            this.trackBarB.TabIndex = 62;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(691, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(952, 514);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 60;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(474, 43);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 319);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button14.Location = new System.Drawing.Point(1098, 576);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(150, 60);
            this.button14.TabIndex = 64;
            this.button14.Text = "ÖTELEME";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click_2);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Cyan;
            this.button19.Location = new System.Drawing.Point(929, 576);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(150, 60);
            this.button19.TabIndex = 65;
            this.button19.Text = "GAUSS";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button20.Location = new System.Drawing.Point(1098, 653);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(150, 60);
            this.button20.TabIndex = 66;
            this.button20.Text = "LAPLAS";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button21.Location = new System.Drawing.Point(929, 644);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(150, 60);
            this.button21.TabIndex = 67;
            this.button21.Text = "HİSTOGRAM EŞİTLEME";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 790);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labelkont);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackkont);
            this.Controls.Add(this.labelayna);
            this.Controls.Add(this.labelco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackayna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.trackaz);
            this.Controls.Add(this.texmed);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "8";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackayna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackkont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox texmed;
        private System.Windows.Forms.TrackBar trackaz;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackayna;
        private System.Windows.Forms.Label labelaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelco;
        private System.Windows.Forms.Label labelayna;
        private System.Windows.Forms.Label labelkont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackkont;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
    }
}

