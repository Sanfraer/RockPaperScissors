using System;
using System.Drawing;


namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 
        // Обработчики событий для btnExit
        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(80, 50, 84); // цвет подсветки
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(46, 21, 49); // исходный цвет
        }

        private void BtnAbout_MouseEnter(object sender, EventArgs e)
        {
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(80, 50, 84); // цвет подсветки
        }

        private void BtnAbout_MouseLeave(object sender, EventArgs e)
        {
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(46, 21, 49); // исходный цвет
        }

        private void BtnGame_MouseEnter(object sender, EventArgs e)
        {
            this.btnGame.BackColor = System.Drawing.Color.FromArgb(80, 50, 84); // цвет подсветки
        }

        private void BtnGame_MouseLeave(object sender, EventArgs e)
        {
            this.btnGame.BackColor = System.Drawing.Color.FromArgb(46, 21, 49); // исходный цвет
        }
        private void InitializeComponent()
        {
            this.btnGame = new CustomControls.AlternateControls.AltRoundedButton();
            this.btnAbout = new CustomControls.AlternateControls.AltRoundedButton();
            this.btnExit = new CustomControls.AlternateControls.AltRoundedButton();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.btnGame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.btnGame.BorderRadius = 8;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnGame.ForeColor = System.Drawing.Color.White;
            this.btnGame.Location = new System.Drawing.Point(303, 121);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(200, 50);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "GAME";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.BtnGame_Click);
            this.btnGame.MouseEnter += new System.EventHandler(this.BtnGame_MouseEnter);
            this.btnGame.MouseLeave += new System.EventHandler(this.BtnGame_MouseLeave);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.btnAbout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.btnAbout.BorderRadius = 8;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(303, 190);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 50);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            this.btnAbout.MouseEnter += new System.EventHandler(this.BtnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.BtnAbout_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.btnExit.BorderRadius = 8;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(303, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.AlternateControls.AltRoundedButton btnGame;
        private CustomControls.AlternateControls.AltRoundedButton btnAbout;
        private CustomControls.AlternateControls.AltRoundedButton btnExit;
    }
}
