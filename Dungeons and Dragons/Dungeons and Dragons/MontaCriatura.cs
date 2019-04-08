using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dungeons_and_Dragons
{
    public class MontaCriatura : Criatura
    {
        private string _nome;
        private string _classe;
        private int _etapa;
        private int _valor;
        private int _qtdDadosVida = 0;
        private int _bonus;
        public string Classe { get => _classe; set => _classe = value; }        

        public int MontaFichaPersonagem(int etapa, bool botaoRolaDados)
        {
            int numeroDado;

            if (etapa == 1)
            {
                int[] jogadas = RolaDado(5, 2);

                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    _valor += jogadas[i];
                }

                _qtdDadosVida = _valor - 1;

                return Criaturas[ContCriatura].Nivel = _valor;
            }

            else if (etapa == 2)
            {
                int[] jogadas = RolaDado(6, 5);

                _bonus = 0;
                _valor = 0;
                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    _valor += jogadas[i];
                }

                _valor -= jogadas.Min();

                //Bonus
                if (_valor <= 9)
                {
                    _bonus -= 1;
                }
                else if (_valor == 24)
                {
                    _bonus += 7;
                }
                else
                {
                    for (int i = 12; i <= _valor; i += 2)
                    {
                        _bonus += 1;
                    }
                }

                _valor += _bonus;
                if (_valor < 8) _valor = 8;

                return Criaturas[ContCriatura].Forca = _valor;
            }

            else if (etapa == 3)
            {
                int[] jogadas = RolaDado(6, 5);

                _bonus = 0;
                _valor = 0;
                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    _valor += jogadas[i];
                }

                _valor -= jogadas.Min();

                //Bonus
                if (_valor <= 9)
                {
                    _bonus -= 1;
                }
                else if (_valor == 24)
                {
                    _bonus += 7;
                }
                else
                {
                    for (int i = 12; i <= _valor; i += 2)
                    {
                        _bonus += 1;
                    }
                }

                _valor += _bonus;
                if (_valor < 8) _valor = 8;

                return Criaturas[ContCriatura].Destreza = _valor;
            }

            else if (etapa == 4)
            {
                int[] jogadas = RolaDado(6, 5);

                _bonus = 0;
                _valor = 0;
                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    _valor += jogadas[i];
                }
                _valor -= jogadas.Min();

                if (_valor <= 9)
                {
                    _bonus -= 1;
                }
                else if (_valor == 24)
                {
                    _bonus += 7;
                }
                else
                {
                    for (int i = 12; i <= _valor; i += 2)
                    {
                        _bonus += 1;
                    }
                }

                _valor += _bonus;
                if (_valor < 8) _valor = 8;

                return Criaturas[ContCriatura].Constituicao = _valor;
            }

            else if (etapa == 5)
            {
                int[] jogadas = RolaDado(12, _qtdDadosVida);
                _valor = 0;

                for (int i = 0; i < jogadas.Length; i++)
                {
                    numeroDado = jogadas[i];
                    MessageBox.Show("Número tirado: " + numeroDado.ToString(), (i + 1) + "º Dado", MessageBoxButton.OK, MessageBoxImage.None);
                    _valor += jogadas[i];
                }

                _valor += 12 + Constituicao;
                _valor *= Nivel;

                return Criaturas[ContCriatura].Vida = _valor;
            }

            else
            {
                return 0;
            }

        }
    }
}
