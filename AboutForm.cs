using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            LoadBackButtonImage();
            SetBackground();
        }

        private void LoadBackButtonImage()
        {
            try
            {
                btnBack.BackgroundImage = Image.FromFile(@"images\g.png");
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки изображения кнопки.");
            }
        }
        private void SetBackground()
        {
            try
            {
                this.BackgroundImage = Image.FromFile(@"images\screen.png");
                this.BackgroundImageLayout = ImageLayout.Stretch; // На всю форму
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void LinkLina_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/LinaDugau");
        }

        private void LinkSanfraer_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Sanfraer");
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rulesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rulesLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void LinkLina_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/LinaDugau");
        }

        private void LinkSanfraer_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Sanfraer");
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
