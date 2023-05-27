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
    public partial class ApplicationForm5 : Form
    {
        public ApplicationForm5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();

            // Закрываем текущую форму (старое окно)
            this.Hide();

            // Устанавливаем позицию новой формы в центре экрана
            MainMenu.StartPosition = FormStartPosition.CenterScreen;

            // Открываем новую форму
            MainMenu.ShowDialog();
        }
    }
}
