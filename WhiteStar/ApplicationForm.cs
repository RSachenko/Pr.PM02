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
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        // Объявляем переменную для отслеживания статуса заполнения полей
        private bool isField1Filled = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, заполнено ли поле textBox1
            isField1Filled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isField1Filled)
            {
                // Поле textboBox1 не заполнено
                errorProvider1.SetError(textBox1, "Поле должно быть заполнено!");
                return;
            }
            else
            {
                // Поле textboBox1 заполнено
                errorProvider1.SetError(textBox1, "");

                // Проверяем, заполнено ли следующее поле (например, textBox2)
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    // Оба поля заполнены
                    // Выполняем переход к следующему окну
                    ApplicationForm2 ApplicationForm2 = new ApplicationForm2();

                    // Закрываем текущую форму (старое окно)
                    this.Hide();

                    // Устанавливаем позицию новой формы в центре экрана
                    ApplicationForm2.StartPosition = FormStartPosition.CenterScreen;

                    // Открываем новую форму
                    ApplicationForm2.ShowDialog();
                }
                else
                {
                    // Поле textBox2 не заполнено
                    errorProvider2.SetError(textBox5, "Поле должно быть заполнено!");

                }
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
