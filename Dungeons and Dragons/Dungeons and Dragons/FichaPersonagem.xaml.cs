using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dungeons_and_Dragons
{
    /// <summary>
    /// Lógica interna para FichaJogador.xaml
    /// </summary>
    public partial class FichaJogador : Window
    {
        private int etapa;
        private string classe;
        private string nome;
        private bool botaoRolaDados;
        private bool botaoConfirma;

        public FichaJogador(string nome, string classe)
        {
            InitializeComponent();

            this.nome = nome;
            this.classe = classe;
            LabelNome.Content = nome;
            LabelClasse.Content = classe;
            ImagePersonagem.Source = new BitmapImage(new Uri($@"C:\img\{classe}.png"));
            MediaPersonagem.Source = new Uri($@"C:\img\{classe}.mp3");
            ButtonRolaDados.IsEnabled = false;
            TextoInfo.Text = $"Olá, {nome}, o {classe}! Agora você irá montar a sua ficha, clique em OK e role 2 dados (D5) para saber-mos o seu nível!";

            if (classe.Equals(nameof(Barbaro)))
            {
                Criatura barbaro = new Barbaro();
            }
            else if (classe.Equals(nameof(Clerigo)))
            {
                Criatura clerigo = new Clerigo();
            }
            if (classe.Equals(nameof(Ladino)))
            {
                Criatura barbaro = new Ladino();
            }

        }


        private void ButtonConfirma_Click(object sender, RoutedEventArgs e)
        {
            ButtonConfirma.IsEnabled = false;
            botaoRolaDados = ButtonRolaDados.IsEnabled = true;
            etapa++;
        }

        private void ButtonRolaDados_Click(object sender, RoutedEventArgs e)
        {

            switch (etapa)
            {

                case 1:
                    TextoInfo.Text = $"Certo, agora que você sabe o seu nível, vamos rolar os dados para saber a sua força! São 5 D6, em que o menor dado é desconsiderado";
                    break;
                case 2:
                    TextoInfo.Text = $"Ótimo, agora vamos verificar a sua destreza!";
                    break;
                case 3:
                    TextoInfo.Text = $"Ótimo, agora vamos verificar a sua constituição!";
                    break;
                case 4:
                    TextoInfo.Text = $"Ótimo, agora vamos verificar a sua vida!";
                    break;
                case 5:
                    TextoInfo.Text = $"Agora podemos Começar o jogo!";
                    break;
            }
        }
    }
}


