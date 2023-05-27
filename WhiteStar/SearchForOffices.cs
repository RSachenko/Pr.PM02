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
    public partial class SearchForOffices : Form
    {
        public SearchForOffices()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            comboBox2.Items.Clear(); // Очистка элементов comboBox2

            if (selectedValue == "Европа")
            {
                comboBox2.Items.Add("Москва/Россия");
                comboBox2.Items.Add("Санкт-Петербург/Россия");
                comboBox2.Items.Add("Лондон/Великобритания");
                comboBox2.Items.Add("Берлин/Германия");
                comboBox2.Items.Add("Минск/Белоруссия");
                comboBox2.Items.Add("Стокгольм/Швеция");
                // Добавьте остальные варианты для значения 1
            }
            else if (selectedValue == "Северная Америка")
            {
                comboBox2.Items.Add("Монреаль/Канада");
                comboBox2.Items.Add("Нью-Йорк/США");
                comboBox2.Items.Add("Лос-Анджелес/США");
                // Добавьте остальные варианты для значения 2
            }
            // Добавьте другие условия для остальных значений comboBox1
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
