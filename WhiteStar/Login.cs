using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteStar
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // Объявляем переменную для отслеживания статуса заполнения полей
        private bool isField1Filled = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, заполнено ли поле textBox1
            isField1Filled = !string.IsNullOrEmpty(textBox1.Text);

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string input = textBox1.Text;


            if (!Regex.IsMatch(input, emailPattern))
            {
                // Поле TextBox не заполнено
                errorProvider1.SetError(textBox1, "Некорректный адрес электронной почты!");
                return;
            }
            else
            {
                // Поле textBox1 заполнено
                errorProvider1.SetError(textBox1, "");

                // Проверяем, заполнено ли следующее поле (например, textBox2)
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    // Оба поля заполнены
                    // Выполняем переход к следующему окну
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();4
                    // Создаем экземпляр новой формы
                    MainMenu MainMenu = new MainMenu();

                    // Закрываем текущую форму (старое окно)
                    this.Hide();

                    // Устанавливаем позицию новой формы в центре экрана
                    MainMenu.StartPosition = FormStartPosition.CenterScreen;

                    // Открываем новую форму
                    MainMenu.ShowDialog();


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
            string input = textBox2.Text;
            string maskedInput = new string('*', input.Length);
            textBox2.Text = maskedInput;
            textBox2.SelectionStart = maskedInput.Length;
        }
    }
 }

