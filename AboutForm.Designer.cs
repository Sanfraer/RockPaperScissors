using System.Drawing;
using System.Windows.Forms;
using CustomControls.RJControls;

namespace RockPaperScissors
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBack;
        private RJPanel panel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.LinkLabel linkLina;
        private System.Windows.Forms.LinkLabel linkSanfraer;
        private System.Windows.Forms.Label rulesLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.panel = new CustomControls.RJControls.RJPanel();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.linkLina = new System.Windows.Forms.LinkLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.linkSanfraer = new System.Windows.Forms.LinkLabel();
            this.panel.SuspendLayout();
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
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.panel.BorderRadius = 10;
            this.panel.BorderSize = 0;
            this.panel.Controls.Add(this.rulesLabel);
            this.panel.Controls.Add(this.linkLina);
            this.panel.Controls.Add(this.titleLabel);
            this.panel.Controls.Add(this.linkSanfraer);
            this.panel.Location = new System.Drawing.Point(180, 24);
            this.panel.Name = "panel";
            this.panel.ShadowColor = System.Drawing.Color.Black;
            this.panel.ShadowSize = 10;
            this.panel.Size = new System.Drawing.Size(438, 399);
            this.panel.TabIndex = 0;
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.rulesLabel.ForeColor = System.Drawing.Color.White;
            this.rulesLabel.Location = new System.Drawing.Point(25, 167);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(387, 180);
            this.rulesLabel.TabIndex = 0;
            this.rulesLabel.Text = resources.GetString("rulesLabel.Text");
            // 
            // linkLina
            // 
            this.linkLina.AutoSize = true;
            this.linkLina.Font = new System.Drawing.Font("Arial", 14F);
            this.linkLina.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLina.LinkColor = System.Drawing.Color.White;
            this.linkLina.Location = new System.Drawing.Point(110, 108);
            this.linkLina.Name = "linkLina";
            this.linkLina.Size = new System.Drawing.Size(100, 22);
            this.linkLina.TabIndex = 0;
            this.linkLina.TabStop = true;
            this.linkLina.Text = "LinaDugau";
            this.linkLina.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLina_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(172, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(107, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "About";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // linkSanfraer
            // 
            this.linkSanfraer.AutoSize = true;
            this.linkSanfraer.Font = new System.Drawing.Font("Arial", 14F);
            this.linkSanfraer.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSanfraer.LinkColor = System.Drawing.Color.White;
            this.linkSanfraer.Location = new System.Drawing.Point(245, 108);
            this.linkSanfraer.Name = "linkSanfraer";
            this.linkSanfraer.Size = new System.Drawing.Size(82, 22);
            this.linkSanfraer.TabIndex = 1;
            this.linkSanfraer.TabStop = true;
            this.linkSanfraer.Text = "Sanfraer";
            this.linkSanfraer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSanfraer_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}