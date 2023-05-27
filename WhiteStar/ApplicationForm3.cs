using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WhiteStar
{
    public partial class ApplicationForm3 : Form
    {
        public ApplicationForm3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Объявляем переменную для отслеживания статуса заполнения полей
        private bool isField1Filled = false;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, заполнено ли поле textBox1
            isField1Filled = !string.IsNullOrEmpty(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isField1Filled)
            {
                // Поле comboBox1 не заполнено
                errorProvider1.SetError(comboBox1, "Поле должно быть заполнено!");
                return;
            }
            else
            {
                // Поле comboBox1 заполнено
                errorProvider1.SetError(comboBox1, "");

                // Проверяем, заполнено ли следующее поле (например, textBox2)
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    // Оба поля заполнены
                    // Выполняем переход к следующему окну
                    ApplicationForm4 ApplicationForm4 = new ApplicationForm4();

                    // Закрываем текущую форму (старое окно)
                    this.Hide();

                    // Устанавливаем позицию новой формы в центре экрана
                    ApplicationForm4.StartPosition = FormStartPosition.CenterScreen;

                    // Открываем новую форму
                    ApplicationForm4.ShowDialog();
                }
                else
                {
                    // Поле textBox2 не заполнено
                    errorProvider2.SetError(textBox2, "Поле должно быть заполнено!");

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
