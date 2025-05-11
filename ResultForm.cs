using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RockPaperScissors
{
    public partial class ResultForm : Form
    {
        private int wins;
        private int draws;
        private int losses;
        public ResultForm()
        {
            InitializeComponent();
            SetBackground();
            LoadBackButtonImage();

            UpdateStats();
        }



        private void UpdateStats()
        {
            lblVictory.Text = $"Victory: {wins}";
            lblDraw.Text = $"Draw: {draws}";
            lblLoss.Text = $"Loss: {losses}";
            lblScore.Text = $"{wins}/{draws}/{losses}";
        }
        public void SetStats(int wins, int draws, int losses)
        {
            lblVictory.Text = $"Victory: {wins}";
            lblDraw.Text = $"Draw: {draws}";
            lblLoss.Text = $"Loss: {losses}";
            lblScore.Text = $"{wins}/{draws}/{losses}";
        }



        private void BtnReset_Click(object sender, EventArgs e)
        {
            wins = 0;
            draws = 0;
            losses = 0;
            UpdateStats();

            GameForm form = new GameForm();  // Создание нового экземпляра формы
            form.ResetStats();  // Сбрасываем статистику через экземпляр формы

        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            // Записываем статистику, которая хранится в текущих полях
            string data = $"{lblVictory.Text}\n{lblDraw.Text}\n{lblLoss.Text}";
            File.WriteAllText("result.txt", data);
            MessageBox.Show("Результат экспортирован!");
        }

        private void BtnBack_Click(object sender, EventArgs e) 
        {
            this.Hide(); // СКРЫВАЕМ ЭТО ОКНО
            Form1 mainForm = new Form1(); // СОЗДАЕМ ГЛАВНОЕ МЕНЮ (НЕ ПЕРЕХОДИМ В НЕГО, А ПРОСТО СОЗДАЕМ) 
            mainForm.Show(); // ПОКАЗЫВАЕМ ЕГО 
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
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void lblVictory_Click(object sender, EventArgs e)
        {

        }

        private void lblDraw_Click(object sender, EventArgs e)
        {

        }

        private void lblLoss_Click(object sender, EventArgs e)
        {

        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBackground_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
