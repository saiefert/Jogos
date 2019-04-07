using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dungeons_and_Dragons
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] classes = { "Barbaro", "Clerigo", "Ladino"};
            ComboBoxClasse.ItemsSource = classes;
        }

        private void ButtonConfirma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextBoxNome.Text == "")
                {
                    MessageBox.Show("Seu personagem deve ter um nome!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    string nome = TextBoxNome.Text;
                    string classe = ComboBoxClasse.SelectedItem.ToString();
                    FichaJogador ficha = new FichaJogador(nome, classe);
                    ficha.Show();
                    this.Close();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Você deve selecionar uma classe!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ButtonDuvida_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Para iniciar a construção da sua ficha, insira o nome do seu personagem e a sua classe!");
        }
    }
}
