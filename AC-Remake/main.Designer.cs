
namespace AC_Remake
{
    partial class main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRSide = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.lblGPU2 = new System.Windows.Forms.Label();
            this.lblGPU1 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpbRAM = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cpbCPU = new CircularProgressBar.CircularProgressBar();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pnMainBenchs = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBench3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBench2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBench1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hasOpen = new System.Windows.Forms.Timer(this.components);
            this.pnRSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.pnMain.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pnMainBenchs.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 720);
            this.panel1.TabIndex = 0;
            // 
            // pnRSide
            // 
            this.pnRSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.pnRSide.Controls.Add(this.label21);
            this.pnRSide.Controls.Add(this.lblGPU2);
            this.pnRSide.Controls.Add(this.lblGPU1);
            this.pnRSide.Controls.Add(this.lblCPU);
            this.pnRSide.Controls.Add(this.label2);
            this.pnRSide.Controls.Add(this.cpbRAM);
            this.pnRSide.Controls.Add(this.label1);
            this.pnRSide.Controls.Add(this.cpbCPU);
            this.pnRSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRSide.Location = new System.Drawing.Point(880, 0);
            this.pnRSide.Name = "pnRSide";
            this.pnRSide.Size = new System.Drawing.Size(400, 720);
            this.pnRSide.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label21.Location = new System.Drawing.Point(0, 697);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(400, 23);
            this.label21.TabIndex = 7;
            this.label21.Text = "© JamesCJ 2022";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGPU2
            // 
            this.lblGPU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU2.ForeColor = System.Drawing.Color.Black;
            this.lblGPU2.Location = new System.Drawing.Point(19, 60);
            this.lblGPU2.Name = "lblGPU2";
            this.lblGPU2.Size = new System.Drawing.Size(363, 23);
            this.lblGPU2.TabIndex = 6;
            this.lblGPU2.Text = "GPU: ";
            this.lblGPU2.Visible = false;
            // 
            // lblGPU1
            // 
            this.lblGPU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU1.ForeColor = System.Drawing.Color.Black;
            this.lblGPU1.Location = new System.Drawing.Point(19, 37);
            this.lblGPU1.Name = "lblGPU1";
            this.lblGPU1.Size = new System.Drawing.Size(363, 23);
            this.lblGPU1.TabIndex = 5;
            this.lblGPU1.Text = "GPU: ";
            // 
            // lblCPU
            // 
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.Black;
            this.lblCPU.Location = new System.Drawing.Point(19, 14);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(363, 23);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "CPU: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(247, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAM Usage";
            // 
            // cpbRAM
            // 
            this.cpbRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbRAM.AnimationSpeed = 500;
            this.cpbRAM.BackColor = System.Drawing.Color.Transparent;
            this.cpbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbRAM.ForeColor = System.Drawing.Color.Black;
            this.cpbRAM.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.cpbRAM.InnerMargin = 2;
            this.cpbRAM.InnerWidth = -1;
            this.cpbRAM.Location = new System.Drawing.Point(227, 119);
            this.cpbRAM.MarqueeAnimationSpeed = 2000;
            this.cpbRAM.Name = "cpbRAM";
            this.cpbRAM.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.cpbRAM.OuterMargin = -25;
            this.cpbRAM.OuterWidth = 26;
            this.cpbRAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.cpbRAM.ProgressWidth = 25;
            this.cpbRAM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbRAM.Size = new System.Drawing.Size(153, 153);
            this.cpbRAM.StartAngle = 270;
            this.cpbRAM.SubscriptColor = System.Drawing.Color.Black;
            this.cpbRAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbRAM.SubscriptText = "";
            this.cpbRAM.SuperscriptColor = System.Drawing.Color.Black;
            this.cpbRAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbRAM.SuperscriptText = "";
            this.cpbRAM.TabIndex = 2;
            this.cpbRAM.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbRAM.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU Usage";
            // 
            // cpbCPU
            // 
            this.cpbCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCPU.AnimationSpeed = 500;
            this.cpbCPU.BackColor = System.Drawing.Color.Transparent;
            this.cpbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbCPU.ForeColor = System.Drawing.Color.Black;
            this.cpbCPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.cpbCPU.InnerMargin = 2;
            this.cpbCPU.InnerWidth = -1;
            this.cpbCPU.Location = new System.Drawing.Point(20, 119);
            this.cpbCPU.MarqueeAnimationSpeed = 2000;
            this.cpbCPU.Name = "cpbCPU";
            this.cpbCPU.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.cpbCPU.OuterMargin = -25;
            this.cpbCPU.OuterWidth = 26;
            this.cpbCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.cpbCPU.ProgressWidth = 25;
            this.cpbCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbCPU.Size = new System.Drawing.Size(153, 153);
            this.cpbCPU.StartAngle = 270;
            this.cpbCPU.SubscriptColor = System.Drawing.Color.Black;
            this.cpbCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbCPU.SubscriptText = "";
            this.cpbCPU.SuperscriptColor = System.Drawing.Color.Black;
            this.cpbCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbCPU.SuperscriptText = "";
            this.cpbCPU.TabIndex = 0;
            this.cpbCPU.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbCPU.Value = 68;
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.Controls.Add(this.panel13);
            this.pnMain.Controls.Add(this.pnMainBenchs);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(55, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(825, 720);
            this.pnMain.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel17);
            this.panel13.Controls.Add(this.panel18);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 311);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(38, 10, 12, 10);
            this.panel13.Size = new System.Drawing.Size(825, 311);
            this.panel13.TabIndex = 2;
            this.panel13.Visible = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Silver;
            this.panel14.Controls.Add(this.label15);
            this.panel14.Controls.Add(this.label16);
            this.panel14.Controls.Add(this.button3);
            this.panel14.Controls.Add(this.pictureBox7);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(544, 10);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(10);
            this.panel14.Size = new System.Drawing.Size(240, 291);
            this.panel14.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 178);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.label15.Size = new System.Drawing.Size(220, 55);
            this.label15.TabIndex = 4;
            this.label15.Text = "[Enter Text]";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 144);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label16.Size = new System.Drawing.Size(121, 34);
            this.label16.TabIndex = 2;
            this.label16.Text = "[Enter Name]";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(10, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 45);
            this.button3.TabIndex = 1;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox7.Location = new System.Drawing.Point(10, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(220, 134);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(531, 10);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(13, 291);
            this.panel15.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Silver;
            this.panel16.Controls.Add(this.label17);
            this.panel16.Controls.Add(this.label18);
            this.panel16.Controls.Add(this.button4);
            this.panel16.Controls.Add(this.pictureBox8);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(291, 10);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(10);
            this.panel16.Size = new System.Drawing.Size(240, 291);
            this.panel16.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 178);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.label17.Size = new System.Drawing.Size(220, 55);
            this.label17.TabIndex = 4;
            this.label17.Text = "[Enter Text]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 144);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label18.Size = new System.Drawing.Size(121, 34);
            this.label18.TabIndex = 2;
            this.label18.Text = "[Enter Name]";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(10, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "Run";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox8.Location = new System.Drawing.Point(10, 10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(220, 134);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(278, 10);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(13, 291);
            this.panel17.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Silver;
            this.panel18.Controls.Add(this.label19);
            this.panel18.Controls.Add(this.label20);
            this.panel18.Controls.Add(this.button5);
            this.panel18.Controls.Add(this.pictureBox9);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(38, 10);
            this.panel18.Margin = new System.Windows.Forms.Padding(10);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(10);
            this.panel18.Size = new System.Drawing.Size(240, 291);
            this.panel18.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 178);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.label19.Size = new System.Drawing.Size(220, 55);
            this.label19.TabIndex = 3;
            this.label19.Text = "[Enter Text]";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 144);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label20.Size = new System.Drawing.Size(121, 34);
            this.label20.TabIndex = 2;
            this.label20.Text = "[Enter Name]";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(10, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 45);
            this.button5.TabIndex = 1;
            this.button5.Text = "Run";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox9.Location = new System.Drawing.Point(10, 10);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(220, 134);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // pnMainBenchs
            // 
            this.pnMainBenchs.Controls.Add(this.panel5);
            this.pnMainBenchs.Controls.Add(this.panel6);
            this.pnMainBenchs.Controls.Add(this.panel4);
            this.pnMainBenchs.Controls.Add(this.panel3);
            this.pnMainBenchs.Controls.Add(this.panel2);
            this.pnMainBenchs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMainBenchs.Location = new System.Drawing.Point(0, 0);
            this.pnMainBenchs.Margin = new System.Windows.Forms.Padding(0);
            this.pnMainBenchs.Name = "pnMainBenchs";
            this.pnMainBenchs.Padding = new System.Windows.Forms.Padding(38, 10, 12, 10);
            this.pnMainBenchs.Size = new System.Drawing.Size(825, 311);
            this.pnMainBenchs.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.btnBench3);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(544, 10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(240, 291);
            this.panel5.TabIndex = 4;
            this.panel5.Visible = false;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.label7.Size = new System.Drawing.Size(220, 55);
            this.label7.TabIndex = 4;
            this.label7.Text = "Unity Spaceship demo running with RT and Vulkan.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label8.Size = new System.Drawing.Size(183, 34);
            this.label8.TabIndex = 2;
            this.label8.Text = "Spaceship Demo V2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBench3
            // 
            this.btnBench3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnBench3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBench3.FlatAppearance.BorderSize = 0;
            this.btnBench3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBench3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBench3.ForeColor = System.Drawing.Color.White;
            this.btnBench3.Location = new System.Drawing.Point(10, 236);
            this.btnBench3.Name = "btnBench3";
            this.btnBench3.Size = new System.Drawing.Size(220, 45);
            this.btnBench3.TabIndex = 1;
            this.btnBench3.Text = "Run";
            this.btnBench3.UseVisualStyleBackColor = false;
            this.btnBench3.Click += new System.EventHandler(this.btnBench3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 134);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(531, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 291);
            this.panel6.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnBench2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(291, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(240, 291);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.label5.Size = new System.Drawing.Size(220, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "Forest Demo demo using DX12 and FSR.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label6.Size = new System.Drawing.Size(119, 34);
            this.label6.TabIndex = 2;
            this.label6.Text = "Forest Demo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBench2
            // 
            this.btnBench2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnBench2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBench2.FlatAppearance.BorderSize = 0;
            this.btnBench2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBench2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBench2.ForeColor = System.Drawing.Color.White;
            this.btnBench2.Location = new System.Drawing.Point(10, 236);
            this.btnBench2.Name = "btnBench2";
            this.btnBench2.Size = new System.Drawing.Size(220, 45);
            this.btnBench2.TabIndex = 1;
            this.btnBench2.Text = "Run";
            this.btnBench2.UseVisualStyleBackColor = false;
            this.btnBench2.Click += new System.EventHandler(this.btnBench2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 134);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(278, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 291);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnBench1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(38, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(240, 291);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.label4.Size = new System.Drawing.Size(220, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Forest Demo demo using DX12.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(119, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forest Demo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBench1
            // 
            this.btnBench1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnBench1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBench1.FlatAppearance.BorderSize = 0;
            this.btnBench1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBench1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBench1.ForeColor = System.Drawing.Color.White;
            this.btnBench1.Location = new System.Drawing.Point(10, 236);
            this.btnBench1.Name = "btnBench1";
            this.btnBench1.Size = new System.Drawing.Size(220, 45);
            this.btnBench1.TabIndex = 1;
            this.btnBench1.Text = "Run";
            this.btnBench1.UseVisualStyleBackColor = false;
            this.btnBench1.Click += new System.EventHandler(this.btnBench1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hasOpen
            // 
            this.hasOpen.Enabled = true;
            this.hasOpen.Interval = 5000;
            this.hasOpen.Tick += new System.EventHandler(this.hasOpen_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnRSide);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.main_Load);
            this.pnRSide.ResumeLayout(false);
            this.pnRSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnMainBenchs.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnRSide;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar cpbCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar cpbRAM;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblGPU1;
        private System.Windows.Forms.Label lblGPU2;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnMainBenchs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBench1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBench2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBench3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer hasOpen;
    }
}
