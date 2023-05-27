using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteStar
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Получение размера экрана
            Screen screen = Screen.PrimaryScreen;
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;

            // Расчет координат для центрирования окна
            int windowWidth = this.Width;
            int windowHeight = this.Height;
            int posX = (screenWidth - windowWidth) / 2;
            int posY = (screenHeight - windowHeight) / 2;

            // Установка позиции окна
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(posX, posY);
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationForm ApplicationForm = new ApplicationForm();

            // Закрываем текущую форму (старое окно)
            this.Hide();

            // Устанавливаем позицию новой формы в центре экрана
            ApplicationForm.StartPosition = FormStartPosition.CenterScreen;

            // Открываем новую форму
            ApplicationForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForOffices SearchForOffices = new SearchForOffices();

            // Закрываем текущую форму (старое окно)
            this.Hide();

            // Устанавливаем позицию новой формы в центре экрана
            SearchForOffices.StartPosition = FormStartPosition.CenterScreen;

            // Открываем новую форму
            SearchForOffices.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
