
namespace sakk_GE_PB
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
            this.headerPANEL = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.containerPANEL = new System.Windows.Forms.Panel();
            this.feladBtn = new System.Windows.Forms.Button();
            this.player2_PANEL = new System.Windows.Forms.Panel();
            this.p2LBL = new System.Windows.Forms.Label();
            this.player1_PANEL = new System.Windows.Forms.Panel();
            this.p1LBL = new System.Windows.Forms.Label();
            this.jatekterPANEL = new System.Windows.Forms.Panel();
            this.babukIMG = new System.Windows.Forms.ImageList(this.components);
            this.menu1 = new sakk_GE_PB.Menu();
            this.headerPANEL.SuspendLayout();
            this.containerPANEL.SuspendLayout();
            this.player2_PANEL.SuspendLayout();
            this.player1_PANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPANEL
            // 
            this.headerPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.headerPANEL.Controls.Add(this.button1);
            this.headerPANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPANEL.Location = new System.Drawing.Point(0, 0);
            this.headerPANEL.Name = "headerPANEL";
            this.headerPANEL.Padding = new System.Windows.Forms.Padding(3);
            this.headerPANEL.Size = new System.Drawing.Size(924, 30);
            this.headerPANEL.TabIndex = 0;
            this.headerPANEL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseDown);
            this.headerPANEL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseMove);
            this.headerPANEL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseUp);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(862, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // containerPANEL
            // 
            this.containerPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.containerPANEL.Controls.Add(this.feladBtn);
            this.containerPANEL.Controls.Add(this.player2_PANEL);
            this.containerPANEL.Controls.Add(this.player1_PANEL);
            this.containerPANEL.Controls.Add(this.jatekterPANEL);
            this.containerPANEL.Location = new System.Drawing.Point(142, 62);
            this.containerPANEL.Name = "containerPANEL";
            this.containerPANEL.Size = new System.Drawing.Size(655, 675);
            this.containerPANEL.TabIndex = 2;
            // 
            // feladBtn
            // 
            this.feladBtn.Location = new System.Drawing.Point(282, 24);
            this.feladBtn.Name = "feladBtn";
            this.feladBtn.Size = new System.Drawing.Size(90, 35);
            this.feladBtn.TabIndex = 5;
            this.feladBtn.Text = "Feladás";
            this.feladBtn.UseVisualStyleBackColor = true;
            this.feladBtn.Click += new System.EventHandler(this.feladBtn_Click);
            // 
            // player2_PANEL
            // 
            this.player2_PANEL.BackColor = System.Drawing.Color.White;
            this.player2_PANEL.Controls.Add(this.p2LBL);
            this.player2_PANEL.Location = new System.Drawing.Point(500, 15);
            this.player2_PANEL.Name = "player2_PANEL";
            this.player2_PANEL.Size = new System.Drawing.Size(117, 48);
            this.player2_PANEL.TabIndex = 2;
            // 
            // p2LBL
            // 
            this.p2LBL.BackColor = System.Drawing.Color.White;
            this.p2LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2LBL.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2LBL.Location = new System.Drawing.Point(3, 7);
            this.p2LBL.Name = "p2LBL";
            this.p2LBL.Size = new System.Drawing.Size(114, 32);
            this.p2LBL.TabIndex = 4;
            this.p2LBL.Text = "Player2";
            this.p2LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_PANEL
            // 
            this.player1_PANEL.BackColor = System.Drawing.Color.Black;
            this.player1_PANEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_PANEL.Controls.Add(this.p1LBL);
            this.player1_PANEL.Location = new System.Drawing.Point(40, 15);
            this.player1_PANEL.Name = "player1_PANEL";
            this.player1_PANEL.Size = new System.Drawing.Size(117, 48);
            this.player1_PANEL.TabIndex = 1;
            // 
            // p1LBL
            // 
            this.p1LBL.BackColor = System.Drawing.Color.Black;
            this.p1LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1LBL.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1LBL.ForeColor = System.Drawing.Color.White;
            this.p1LBL.Location = new System.Drawing.Point(3, 6);
            this.p1LBL.Name = "p1LBL";
            this.p1LBL.Size = new System.Drawing.Size(109, 32);
            this.p1LBL.TabIndex = 5;
            this.p1LBL.Text = "Player1";
            this.p1LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jatekterPANEL
            // 
            this.jatekterPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.jatekterPANEL.Location = new System.Drawing.Point(40, 84);
            this.jatekterPANEL.Name = "jatekterPANEL";
            this.jatekterPANEL.Size = new System.Drawing.Size(577, 577);
            this.jatekterPANEL.TabIndex = 0;
            // 
            // babukIMG
            // 
            this.babukIMG.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.babukIMG.ImageSize = new System.Drawing.Size(200, 200);
            this.babukIMG.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1.Location = new System.Drawing.Point(0, 30);
            this.menu1.MaximumSize = new System.Drawing.Size(940, 790);
            this.menu1.MinimumSize = new System.Drawing.Size(940, 790);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(940, 790);
            this.menu1.TabIndex = 3;
            this.menu1.Load += new System.EventHandler(this.menu1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(924, 751);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.containerPANEL);
            this.Controls.Add(this.headerPANEL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPANEL.ResumeLayout(false);
            this.containerPANEL.ResumeLayout(false);
            this.player2_PANEL.ResumeLayout(false);
            this.player1_PANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPANEL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel containerPANEL;
        private System.Windows.Forms.Panel player2_PANEL;
        private System.Windows.Forms.Label p2LBL;
        private System.Windows.Forms.Panel player1_PANEL;
        private System.Windows.Forms.Label p1LBL;
        private System.Windows.Forms.Panel jatekterPANEL;
        private System.Windows.Forms.ImageList babukIMG;
        private System.Windows.Forms.Button feladBtn;
        private Menu menu1;
    }
}

