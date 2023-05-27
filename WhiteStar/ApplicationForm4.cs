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
    public partial class ApplicationForm4 : Form
    {
        public ApplicationForm4()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите имя...")
            {
                textBox1.Text = string.Empty;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите имя...")
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = SystemColors.WindowText; // Возвращаем цвет по умолчанию
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Имя*";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите фамилию...")
            {
                textBox2.Text = string.Empty;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите фамилию...")
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = SystemColors.WindowText; // Возвращаем цвет по умолчанию
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "Фамилия*";
                textBox2.ForeColor = Color.Gray;
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "Введите название компании...")
            {
                textBox3.Text = string.Empty;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Введите название компании...")
            {
                textBox3.Text = string.Empty;
                textBox3.ForeColor = SystemColors.WindowText; // Возвращаем цвет по умолчанию
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = "Название компании*";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "Введите адрес электронной почты...")
            {
                textBox4.Text = string.Empty;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Введите адрес электронной почты...")
            {
                textBox4.Text = string.Empty;
                textBox4.ForeColor = SystemColors.WindowText; // Возвращаем цвет по умолчанию
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text = "Адрес электронной почты*";
                textBox4.ForeColor = Color.Gray;
            }
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "Введите почтовый индекс...")
            {
                textBox5.Text = string.Empty;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Введите почтовый индекс...")
            {
                textBox5.Text = string.Empty;
                textBox5.ForeColor = SystemColors.WindowText; // Возвращаем цвет по умолчанию
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox5.Text = "Почтовый индекс*";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "Введите город...")
            {
                textBox6.Text = string.Empty;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Введите город...")
            {
                textBox6.Text = string.Empty;
                textBox6.ForeColor = SystemColors.WindowText; // Возвращаем цвет по умолчанию
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Text = "Город*";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "Введите номер телефона...")
            {
                textBox7.Text = string.Empty;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Введите номер телефона...")
            {
                textBox7.Text = string.Empty;
                textBox7.ForeColor = SystemColors.WindowText; // Возвращаем цвет по умолчанию
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                textBox7.Text = "Номер телефона*";
                textBox7.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Веберите вашу страну/регион...")
            {
                comboBox1.Text = string.Empty;
            }
        }
        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Выберите вашу страну/регион...")
            {
                comboBox1.Text = string.Empty;
                comboBox1.ForeColor = SystemColors.WindowText; // Возвращаем цвет по умолчанию
            }
        }
        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                comboBox1.Text = "Выберите вашу страну/регион*";
                comboBox1.ForeColor = Color.Gray;
            }
        }


        private void ApplicationForm4_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Введите имя...";
            textBox1.ForeColor = Color.Gray;

            textBox2.Text = "Введите фамилию...";
            textBox2.ForeColor = Color.Gray;

            textBox3.Text = "Введите название компании...";
            textBox3.ForeColor = Color.Gray;

            textBox4.Text = "Введите адрес электронной почты...";
            textBox4.ForeColor = Color.Gray;

            textBox5.Text = "Введите почтовый индекс...";
            textBox5.ForeColor = Color.Gray;

            textBox6.Text = "Введите город...";
            textBox6.ForeColor = Color.Gray;

            textBox7.Text = "Введите номер телефона...";
            textBox7.ForeColor = Color.Gray;

            comboBox1.Text = "Выберите вашу страну/регион";
            comboBox1.ForeColor = Color.Gray;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationForm5 ApplicationForm5 = new ApplicationForm5();

            // Закрываем текущую форму (старое окно)
            this.Hide();

            // Устанавливаем позицию новой формы в центре экрана
            ApplicationForm5.StartPosition = FormStartPosition.CenterScreen;

            // Открываем новую форму
            ApplicationForm5.ShowDialog();

        }
    }
}
