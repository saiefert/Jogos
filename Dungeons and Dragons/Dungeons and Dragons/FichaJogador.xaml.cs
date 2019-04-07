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
        private string nome;
        private string classe;
        private int etapa;
        private int valor;
        private int qtdDadosVida = 0;
        private int bonus;
        private bool botaoRolaDados;

        MontaFicha montaFicha = new MontaFicha();
        Criatura barbaro = new Barbaro();
        Criatura clerigo = new Barbaro();
        Criatura ladino = new Ladino();

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
        }

        private void ButtonConfirma_Click(object sender, RoutedEventArgs e)
        {
            ButtonConfirma.IsEnabled = false;
            botaoRolaDados = ButtonRolaDados.IsEnabled = true;
            etapa++;
        }

        private void ButtonRolaDados_Click(object sender, RoutedEventArgs e)
        {
            if (classe.Equals(nameof(Barbaro)))
            {
                montaFicha.MontaFichaPersonagem(barbaro, etapa, botaoRolaDados);
            }
            else if (classe.Equals(nameof(Clerigo)))
            {
                montaFicha.MontaFichaPersonagem(clerigo, etapa, botaoRolaDados);
            }
            else if (classe.Equals(nameof(Ladino)))
            {
                montaFicha.MontaFichaPersonagem(ladino, etapa, botaoRolaDados);
            }
        }
    }
}


