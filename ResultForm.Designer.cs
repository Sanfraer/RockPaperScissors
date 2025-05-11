using CustomControls.RJControls;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissors
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBack;
        private RJPanel panelBackground;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblVictory = new System.Windows.Forms.Label();
            this.panelBackground = new CustomControls.RJControls.RJPanel();
            this.btnExport = new CustomControls.RJControls.RJButton();
            this.btnReset = new CustomControls.RJControls.RJButton();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(10, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 12F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(151, 163);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(43, 18);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0/0/0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Font = new System.Drawing.Font("Arial", 10F);
            this.lblLoss.ForeColor = System.Drawing.Color.White;
            this.lblLoss.Location = new System.Drawing.Point(142, 130);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(53, 16);
            this.lblLoss.TabIndex = 2;
            this.lblLoss.Text = "Loss: 0";
            this.lblLoss.Click += new System.EventHandler(this.lblLoss_Click);
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDraw.ForeColor = System.Drawing.Color.White;
            this.lblDraw.Location = new System.Drawing.Point(142, 89);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(55, 16);
            this.lblDraw.TabIndex = 1;
            this.lblDraw.Text = "Draw: 0";
            this.lblDraw.Click += new System.EventHandler(this.lblDraw_Click);
            // 
            // lblVictory
            // 
            this.lblVictory.AutoSize = true;
            this.lblVictory.Font = new System.Drawing.Font("Arial", 10F);
            this.lblVictory.ForeColor = System.Drawing.Color.White;
            this.lblVictory.Location = new System.Drawing.Point(142, 49);
            this.lblVictory.Name = "lblVictory";
            this.lblVictory.Size = new System.Drawing.Size(66, 16);
            this.lblVictory.TabIndex = 0;
            this.lblVictory.Text = "Victory: 0";
            this.lblVictory.Click += new System.EventHandler(this.lblVictory_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.panelBackground.BorderColor = System.Drawing.Color.Cyan;
            this.panelBackground.BorderRadius = 15;
            this.panelBackground.BorderSize = 0;
            this.panelBackground.Controls.Add(this.lblVictory);
            this.panelBackground.Controls.Add(this.lblDraw);
            this.panelBackground.Controls.Add(this.lblLoss);
            this.panelBackground.Controls.Add(this.lblScore);
            this.panelBackground.Controls.Add(this.btnExport);
            this.panelBackground.Controls.Add(this.btnReset);
            this.panelBackground.Location = new System.Drawing.Point(236, 50);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.ShadowColor = System.Drawing.Color.Black;
            this.panelBackground.ShadowSize = 20;
            this.panelBackground.Size = new System.Drawing.Size(346, 343);
            this.panelBackground.TabIndex = 1;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint_1);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
            this.btnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
            this.btnExport.BorderColor = System.Drawing.Color.Transparent;
            this.btnExport.BorderRadius = 10;
            this.btnExport.BorderSize = 2;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(15, 242);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 40);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
            this.btnReset.BorderColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 10;
            this.btnReset.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(181, 242);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // ResultForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        private RJButton btnReset;
        private RJButton btnExport;
        private Label lblScore;
        private Label lblLoss;
        private Label lblDraw;
        private Label lblVictory;
    }
}
