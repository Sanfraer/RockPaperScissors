using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class GameForm : Form
    {
        private PictureBox pbRock, pbPaper, pbScissors, pbHelp, pbBack;
        //private Panel choicePanel, helpPanel, scorePanel;
        private RJPanel choicePanel, helpPanel, scorePanel;
        private Label lblScore;

        private System.Windows.Forms.Button btnBack;

        private static int wins = 0, draws = 0, losses = 0;

        public GameForm()
        {
            InitializeComponent();
            SetBackground();
            CreatePanels();
            CreateScorePanel();
            CreateChoiceButtons();
            CreateHelpButton();
            CreateBackButton();

            UpdateScore();

        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            ResultForm resultForm = new ResultForm();
            resultForm.SetStats(wins, draws, losses);

            resultForm.Show();
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
                MessageBox.Show("Ошибка загрузки фона: " + ex.Message);
            }
        }

        private void CreatePanels()
        {
            // Панель для выбора (фиолетовый прямоугольник)
            choicePanel = new RJPanel();
            choicePanel.Size = new Size(390, 140);
            choicePanel.Location = new Point((this.ClientSize.Width - choicePanel.Width) / 2, (this.ClientSize.Height - choicePanel.Height) / 2);
            choicePanel.BackColor = Color.FromArgb(46, 21, 49);
            choicePanel.BorderRadius = 10; 
            choicePanel.BorderColor = Color.White;
            choicePanel.BorderSize = 0;
            this.Controls.Add(choicePanel);

            // Панель для знака вопроса (фиолетовый квадрат)
            helpPanel = new RJPanel();
            helpPanel.Size = new Size(100, 100);
            helpPanel.Location = new Point(this.ClientSize.Width - 120, 20);
            helpPanel.BackColor = Color.FromArgb(46, 21, 49);
            helpPanel.BorderRadius = 10;
            helpPanel.BorderColor = Color.White;
            helpPanel.BorderSize = 0;
            this.Controls.Add(helpPanel);
        }

        private void CreateScorePanel()
        {
           
            scorePanel = new RJPanel();
            scorePanel.Size = new Size(290, 50);
            scorePanel.Location = new Point((this.ClientSize.Width - scorePanel.Width) / 2, 10);
            scorePanel.BackColor = Color.FromArgb(46, 21, 49);

            // Настройки закругления и границы
            scorePanel.BorderRadius = 5; 
            scorePanel.BorderColor = Color.FromArgb(46, 21, 49); 
            scorePanel.BorderSize = 0; 

            // Добавляем панель на форму
            this.Controls.Add(scorePanel);

            // Текстовый счетчик
            lblScore = new Label();
            lblScore.Text = $"Wins {wins}  Draws: {draws}  Losses: {losses}";
            lblScore.Font = new Font("Arial", 14, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.AutoSize = true;
            lblScore.Location = new Point(10, 15);

            scorePanel.Controls.Add(lblScore);
        }



        private void CreateChoiceButtons()
        {
            // Панель выбора
            if (choicePanel == null)
            {
                choicePanel = new RJPanel();
                choicePanel.Size = new Size(400, 120);
                choicePanel.Location = new Point((this.ClientSize.Width - choicePanel.Width) / 2, this.ClientSize.Height - 150);
                choicePanel.BorderSize = 0;

                this.Controls.Add(choicePanel);
            }

            int panelWidth = 110;
            int panelHeight = 110;
            int yOffset = 15;
            int spacing = (choicePanel.Width - (3 * panelWidth)) / 4; // 4 промежутка: слева, между, между, справа

            // Создание и позиционирование панелей
            Panel panelRock = CreateChoicePictureBox(@"images\b.png", 0);
            Panel panelPaper = CreateChoicePictureBox(@"images\k.png", 0);
            Panel panelScissors = CreateChoicePictureBox(@"images\n.png", 0);

            // Задаем позиции с равными отступами
            panelRock.Location = new Point(spacing, yOffset);
            panelPaper.Location = new Point(spacing * 2 + panelWidth, yOffset);
            panelScissors.Location = new Point(spacing * 3 + panelWidth * 2, yOffset);

            // Получаем PictureBox из панелей
            PictureBox pbRock = (PictureBox)panelRock.Controls[0];
            PictureBox pbPaper = (PictureBox)panelPaper.Controls[0];
            PictureBox pbScissors = (PictureBox)panelScissors.Controls[0];

            // Добавляем обработчики кликов
            pbRock.Click += (s, e) => SelectChoice(pbRock);
            pbPaper.Click += (s, e) => SelectChoice(pbPaper);
            pbScissors.Click += (s, e) => SelectChoice(pbScissors);

            // Добавляем панели в choicePanel
            choicePanel.Controls.Add(panelRock);
            choicePanel.Controls.Add(panelPaper);
            choicePanel.Controls.Add(panelScissors);
        }


        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private async void SelectChoice(PictureBox selected)
        {
            choicePanel.Controls.Clear(); // Удаляем старые картинки
            CreateChoiceButtons();        // Заново создаем кнопки выбора
            choicePanel.Visible = false;

            // Панель для рамки таймера
            RoundedPanel countdownPanel = new RoundedPanel
            {
                Size = new Size(120, 70),
                Location = new Point((this.ClientSize.Width - 120) / 2, this.ClientSize.Height / 2 - 50),
                BackColor = Color.Transparent, 
                BorderRadius = 10, 
                BorderSize = 2 
            };
            this.Controls.Add(countdownPanel);
            countdownPanel.BringToFront();

            // Сам таймер (Label)
            Label countdownLabel = new Label
            {
                Size = new Size(120, 70),
                Location = new Point(0, 0),
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(143, 58, 157) // Розовый цвет 
            };
            countdownPanel.Controls.Add(countdownLabel);

            // Отсчет
            for (int i = 3; i > 0; i--)
            {
                countdownLabel.Text = i.ToString() + "...";
                await Task.Delay(1000);
            }

            // Удаляем таймер
            this.Controls.Remove(countdownPanel);
            countdownPanel.Dispose();

            // Картинку в левый угол
            // Картинку в левый угол
            selected.Size = new Size(100, 100);
            selected.Location = new Point(15, this.ClientSize.Height - 105);
            selected.BringToFront();
            selected.Enabled = false; // На всякий случай, чтобы игнорировалось

          


            // Рандомный выбор бота
            string[] botImages =
            {
                @"images\b.png",
                @"images\k.png",
                @"images\n.png"
            };

            Random rand = new Random();
            string botChoiceImage = botImages[rand.Next(botImages.Length)];

            // Добавляем изображение выбора бота
            Panel botPanel = CreateChoicePictureBox(botChoiceImage, this.ClientSize.Width - 120, interactive: false);

            // Получаем PictureBox из панели
            PictureBox botChoice = (PictureBox)botPanel.Controls[0];

            // Размещаем картинку в нужной позиции
 
 
            botChoice.Enabled = false;
            botPanel.Location = new Point(this.ClientSize.Width - 120, 20);
            this.Controls.Add(botPanel);
            botPanel.BringToFront();

            // Логика игры
            string result = DetermineResult(selected, botChoice);

            // Обновление счета
            if (result == "Win")
            {
                wins++;
            }
            else if (result == "Loss")
            {
                losses++;
            }
            else if (result == "Draw")
            {
                draws++;
            }

            // Обновление текстового поля с результатом
            UpdateScore();


            await Task.Delay(3000);

            // Удаляем выбор игрока и бота, если они были добавлены
            // Удаляем выбор игрока
            this.Controls.Remove(selected);
            selected.Dispose();

            // Удаляем выбор бота
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel p && p.Controls.Count > 0 && p.Controls[0] is PictureBox pic)
                {
                    if (pic.Tag != null &&
                        (pic.Tag.ToString().EndsWith("b.png") ||
                         pic.Tag.ToString().EndsWith("k.png") ||
                         pic.Tag.ToString().EndsWith("n.png")))
                    {
                        this.Controls.Remove(p);
                        p.Dispose();
                        break;
                    }
                }
            }

            // Показываем панель снова для следующего раунда
            choicePanel.Controls.Clear(); // Удаляем старые кнопки
            CreateChoiceButtons();
            choicePanel.Visible = true;
        }





        private string DetermineResult(PictureBox playerChoice, PictureBox botChoice)
        {
            if (playerChoice.Tag == null || botChoice.Tag == null)
            {
                MessageBox.Show("Ошибка: изображение не загружено.");
                return "Error";
            }

            string playerChoiceName = Path.GetFileName(playerChoice.Tag.ToString());
            string botChoiceName = Path.GetFileName(botChoice.Tag.ToString());

            if (playerChoiceName == "b.png" && botChoiceName == "n.png" ||
                playerChoiceName == "k.png" && botChoiceName == "b.png" ||
                playerChoiceName == "n.png" && botChoiceName == "k.png")
            {
                return "Loss";
            }
            else if (playerChoiceName == botChoiceName)
            {
                return "Draw";
            }
            else
            {
                return "Win";
            }
        }

        private void MakeRounded(PictureBox pb, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pb.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pb.Width - radius, pb.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pb.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            pb.Region = new Region(path);
        }

        private Panel CreateChoicePictureBox(string imagePath, int xPos, bool interactive = true)
        {
            Panel panel = new Panel();
            panel.Size = new Size(110, 110);  // Размер панели
            panel.Location = new Point(xPos, 25);
            panel.BackColor = Color.Transparent;

            PictureBox pb = new PictureBox();
            pb.Size = new Size(100, 100);  // Размер изображения
            pb.Location = new Point(5, 5);
            pb.SizeMode = PictureBoxSizeMode.Zoom;  // Масштабируем изображение по размеру
            pb.BackColor = Color.White;
            pb.BorderStyle = BorderStyle.FixedSingle;

            // Радиус
            MakeRounded(pb, 20);

            try
            {
                pb.Image = Image.FromFile(imagePath);
                pb.Tag = imagePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }

            // Только если interactive == true, добавляем клик
            if (interactive)
            {
                
                panel.Paint += (s, e) =>
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddRectangle(new Rectangle(0, 0, panel.Width, panel.Height));
                        using (PathGradientBrush brush = new PathGradientBrush(path))
                        {
                            brush.CenterColor = Color.FromArgb(100, 163, 108, 225);
                            brush.SurroundColors = new Color[] { Color.Transparent };
                            e.Graphics.FillRectangle(brush, new Rectangle(0, 0, panel.Width, panel.Height));
                        }
                    }
                };

                pb.MouseEnter += (s, e) =>
                {
                    panel.BackColor = Color.FromArgb(158, 126, 176);
                    panel.Invalidate();
                };

                pb.MouseLeave += (s, e) =>
                {
                    panel.BackColor = Color.Transparent;
                    panel.Invalidate();
                };               

                pb.Click += (s, e) => MoveChoiceToCorner(pb);
            }

            panel.Controls.Add(pb);
            return panel;
        }





        private void MoveChoiceToCorner(PictureBox pb)
        {
            pb.Parent = this; // Перемещаем PictureBox на главный экран
            pb.BringToFront(); // Делаем его перед всеми элементами
            pb.Location = new Point(10, this.ClientSize.Height - pb.Height - 10); // Перемещаем в левый нижний угол
        }

        private void CreateHelpButton()
        {
            pbHelp = new PictureBox();
            pbHelp.Size = new Size(100, 100); // Размер контейнера
            pbHelp.SizeMode = PictureBoxSizeMode.CenterImage; // Размещаем знак вопроса по центру
            pbHelp.BackColor = Color.Transparent;

            try
            {
                Image originalImage = Image.FromFile(@"images\path.png");

                int newWidth = 50; // Ширина 
                int newHeight = 85; // Высота
                Bitmap resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight));

                pbHelp.Image = resizedImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }

            helpPanel.Controls.Add(pbHelp);
        }

        private void CreateBackButton()
        {
            btnBack = new Button();
            btnBack.Size = new Size(40, 40);
            btnBack.Location = new Point(10, 10); // Левый верхний угол
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;

            try
            {
                btnBack.BackgroundImage = Image.FromFile(@"images\g.png");
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки изображения кнопки.");
            }

            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);
        }



        private void UpdateScore()
        {
            lblScore.Text = $"Wins: {wins}  Draws: {draws}  Losses: {losses}";
        }


        public void ResetStats()
        {
            wins = 0;
            draws = 0;
            losses = 0;
            UpdateScore();
        }
    }
}
