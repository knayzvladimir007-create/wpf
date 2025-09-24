using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Foreground == Brushes.Gray)
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "UsernameTextBox")
                {
                    textBox.Text = "Введите имя пользователя";
                }
                else if (textBox.Name == "EmailTextBox")
                {
                    textBox.Text = "exam@yandex.ru";
                }
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Здесь будет логика регистрации
            MessageBox.Show("Регистрация выполнена!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Здесь будет логика возврата назад
            this.Close();
        }
    }
}