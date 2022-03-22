
namespace AC_Remake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnSide = new System.Windows.Forms.Panel();
            this.tHover = new System.Windows.Forms.Timer(this.components);
            this.pnHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnMaximise = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnSide.SuspendLayout();
            this.pnHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSide
            // 
            this.pnSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.pnSide.Controls.Add(this.btnResults);
            this.pnSide.Controls.Add(this.btnMain);
            this.pnSide.Controls.Add(this.btnToggle);
            this.pnSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSide.Location = new System.Drawing.Point(0, 35);
            this.pnSide.Name = "pnSide";
            this.pnSide.Size = new System.Drawing.Size(200, 685);
            this.pnSide.TabIndex = 0;
            // 
            // tHover
            // 
            this.tHover.Enabled = true;
            this.tHover.Interval = 6;
            this.tHover.Tick += new System.EventHandler(this.tHover_Tick);
            // 
            // pnHead
            // 
            this.pnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.pnHead.Controls.Add(this.label1);
            this.pnHead.Controls.Add(this.btnMinimise);
            this.pnHead.Controls.Add(this.btnMaximise);
            this.pnHead.Controls.Add(this.btnClose);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(1280, 35);
            this.pnHead.TabIndex = 1;
            this.pnHead.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHead_Paint);
            this.pnHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseDown);
            this.pnHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseMove);
            this.pnHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "[Enter Name]";
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnMinimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.ForeColor = System.Drawing.Color.White;
            this.btnMinimise.Location = new System.Drawing.Point(1175, 0);
            this.btnMinimise.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(35, 35);
            this.btnMinimise.TabIndex = 6;
            this.btnMinimise.Text = "_";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(0, 35);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1280, 685);
            this.pnControl.TabIndex = 0;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResults.Image = ((System.Drawing.Image)(resources.GetObject("btnResults.Image")));
            this.btnResults.Location = new System.Drawing.Point(0, 100);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(200, 50);
            this.btnResults.TabIndex = 5;
            this.btnResults.Text = "   Results      ";
            this.btnResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.Location = new System.Drawing.Point(0, 50);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(200, 50);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "   Main Menu";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToggle.Image = ((System.Drawing.Image)(resources.GetObject("btnToggle.Image")));
            this.btnToggle.Location = new System.Drawing.Point(0, 0);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(200, 50);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = " ";
            this.btnToggle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnMaximise
            // 
            this.btnMaximise.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximise.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnMaximise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximise.ForeColor = System.Drawing.Color.White;
            this.btnMaximise.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximise.Image")));
            this.btnMaximise.Location = new System.Drawing.Point(1210, 0);
            this.btnMaximise.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Size = new System.Drawing.Size(35, 35);
            this.btnMaximise.TabIndex = 5;
            this.btnMaximise.UseVisualStyleBackColor = false;
            this.btnMaximise.Visible = false;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1245, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnSide);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnSide.ResumeLayout(false);
            this.pnHead.ResumeLayout(false);
            this.pnHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSide;
        private System.Windows.Forms.Timer tHover;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button btnMaximise;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResults;
    }
}

