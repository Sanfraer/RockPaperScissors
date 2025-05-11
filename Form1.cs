using System;
using System.Windows.Forms;  
using System.Drawing;
using System.ComponentModel;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public static int victories = 0; 
        public static int draws = 0;     
        public static int losses = 0;    

        public Form1()
        {
            this.Text = "Main Menu";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            InitializeComponent();  // Инициализация компонентов из Designer.cs
            SetBackground();
           
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.ShowDialog();
            this.Show();
        }

        private void BtnResults_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            this.Hide();
            resultForm.ShowDialog();
            this.Show();
        }
        private void UpdateResult(string result)
        {
            if (result == "Win")
                victories++;
            else if (result == "Draw")
                draws++;
            else if (result == "Loss")
                losses++;
        }
 

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Закрыть приложение
            Application.Exit();
        }


        private void BtnGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }
        private void SetBackground()
        {
            try
            {
                this.BackgroundImage = Image.FromFile(@"Images\screen.png");
                this.BackgroundImageLayout = ImageLayout.Stretch; // На всю форму
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }
        }

       

        private void BtnResult_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show();
            this.Hide();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
            this.Hide();
        }

        // Program.cs Эта хрень идет автоматически
        /* [STAThread]
         static void Main()
         {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());
         } */
    }
}
