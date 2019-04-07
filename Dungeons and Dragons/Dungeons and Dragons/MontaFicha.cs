using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dungeons_and_Dragons
{
    public class MontaFicha : Criatura
    {
        private string nome;
        private string classe;
        private int etapa;
        private int valor;
        private int qtdDadosVida = 0;
        private int bonus;

        public void MontaFichaPersonagem(Criatura personagem, int etapa, bool botaoRolaDados)
        {
            int numeroDado;

            if (etapa == 1 && botaoRolaDados == true)
            {
                int[] jogadas = criatura.RolaDado(5, 2);

                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    valor += jogadas[i];
                }

                criatura.MontaFicha(criatura, etapa, valor);
                TextBlockNivel.Text = ("Nivel: " + valor);
                ButtonRolaDados.IsEnabled = false;
                ButtonConfirma.IsEnabled = true;

                qtdDadosVida = valor - 1;
                TextoInfo.Text = $"Certo, agora que você sabe o seu nível, vamos rolar os dados para saber a sua força! São 5 D6, em que o menor dado é desconsiderado";
            }

            else if (etapa == 2 && botaoRolaDados == true)
            {
                int[] jogadas = criatura.RolaDado(6, 5);

                bonus = 0;
                valor = 0;
                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    valor += jogadas[i];
                }

                valor -= jogadas.Min();

                //Bonus
                if (valor <= 9)
                {
                    bonus -= 1;
                }
                else if (valor == 24)
                {
                    bonus += 7;
                }
                else
                {
                    for (int i = 12; i <= valor; i += 2)
                    {
                        bonus += 1;
                    }
                }

                valor += bonus;
                if (valor < 8) valor = 8;
                criatura.MontaFicha(criatura, etapa, valor);
                //TextBlockForca.Text = ("Força: " + valor);
                //ButtonRolaDados.IsEnabled = false;
                //ButtonConfirma.IsEnabled = true;
                //TextoInfo.Text = $"Ótimo, agora vamos verificar a sua destreza!";
            }

            else if (etapa == 3 && botaoRolaDados == true)
            {
                int[] jogadas = criatura.RolaDado(6, 5);

                bonus = 0;
                valor = 0;
                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    valor += jogadas[i];
                }

                valor -= jogadas.Min();

                //Bonus
                if (valor <= 9)
                {
                    bonus -= 1;
                }
                else if (valor == 24)
                {
                    bonus += 7;
                }
                else
                {
                    for (int i = 12; i <= valor; i += 2)
                    {
                        bonus += 1;
                    }
                }

                valor += bonus;
                if (valor < 8) valor = 8;
                criatura.MontaFicha(criatura, etapa, valor);
                TextBlockDestreza.Text = ("Destreza: " + valor);
                ButtonRolaDados.IsEnabled = false;
                ButtonConfirma.IsEnabled = true;
                TextoInfo.Text = $"Ótimo, agora vamos verificar a sua constituição!";
            }

            else if (etapa == 4 && botaoRolaDados == true)
            {
                int[] jogadas = barbaro.RolaDado(6, 5);

                bonus = 0;
                valor = 0;
                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    valor += jogadas[i];
                }

                valor -= jogadas.Min();
                //Bonus
                if (valor <= 9)
                {
                    bonus -= 1;
                }
                else if (valor == 24)
                {
                    bonus += 7;
                }
                else
                {
                    for (int i = 12; i <= valor; i += 2)
                    {
                        bonus += 1;
                    }
                }

                valor += bonus;
                if (valor < 8) valor = 8;
                barbaro.MontaFicha(barbaro, etapa, valor);
                TextBlockConstituicao.Text = ("Constituição: " + valor);
                ButtonRolaDados.IsEnabled = false;
                ButtonConfirma.IsEnabled = true;
                TextoInfo.Text = $"Ótimo, agora vamos verificar a sua vida!";
            }

            else if (etapa == 5 && botaoRolaDados == true)
            {
                int[] jogadas = criatura.RolaDado(12, qtdDadosVida);
                valor = 0;

                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    valor += jogadas[i];
                }

                valor += 12 + criatura.Constituicao;
                valor *= barbaro.Nivel;
                barbaro.MontaFicha(barbaro, etapa, valor);
                TextBlockVida.Text = ("Vida: " + valor);
                ButtonRolaDados.IsEnabled = false;
                ButtonConfirma.IsEnabled = true;

            }

        }
    }
}
