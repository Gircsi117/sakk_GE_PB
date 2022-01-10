
namespace sakk_GE_PB
{
    partial class Menu
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
            this.cimLBL = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.p1TBOX = new System.Windows.Forms.TextBox();
            this.p2TBOX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cimLBL
            // 
            this.cimLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cimLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cimLBL.Location = new System.Drawing.Point(160, 120);
            this.cimLBL.Margin = new System.Windows.Forms.Padding(0);
            this.cimLBL.Name = "cimLBL";
            this.cimLBL.Size = new System.Drawing.Size(600, 88);
            this.cimLBL.TabIndex = 2;
            this.cimLBL.Text = "Sakk";
            this.cimLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(389, 430);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(140, 40);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(389, 530);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(140, 40);
            this.infoBtn.TabIndex = 4;
            this.infoBtn.Text = "Info";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(389, 630);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(140, 40);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // p1TBOX
            // 
            this.p1TBOX.BackColor = System.Drawing.Color.Black;
            this.p1TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1TBOX.ForeColor = System.Drawing.Color.White;
            this.p1TBOX.Location = new System.Drawing.Point(167, 280);
            this.p1TBOX.Margin = new System.Windows.Forms.Padding(0);
            this.p1TBOX.Name = "p1TBOX";
            this.p1TBOX.Size = new System.Drawing.Size(191, 48);
            this.p1TBOX.TabIndex = 6;
            this.p1TBOX.TabStop = false;
            this.p1TBOX.Text = "Player1";
            this.p1TBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2TBOX
            // 
            this.p2TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2TBOX.Location = new System.Drawing.Point(555, 280);
            this.p2TBOX.Margin = new System.Windows.Forms.Padding(0);
            this.p2TBOX.Name = "p2TBOX";
            this.p2TBOX.Size = new System.Drawing.Size(191, 48);
            this.p2TBOX.TabIndex = 7;
            this.p2TBOX.TabStop = false;
            this.p2TBOX.Text = "Player2";
            this.p2TBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.p2TBOX);
            this.Controls.Add(this.p1TBOX);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.cimLBL);
            this.MaximumSize = new System.Drawing.Size(940, 790);
            this.MinimumSize = new System.Drawing.Size(940, 790);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(940, 790);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cimLBL;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox p1TBOX;
        private System.Windows.Forms.TextBox p2TBOX;
    }
}
