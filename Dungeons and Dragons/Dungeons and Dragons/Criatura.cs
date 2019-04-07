using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons
{
    public abstract class Criatura : IControladora
    {
        private string _nome;
        private string _classe;
        private int _nivel;
        private int _forca;
        private int _destreza;
        private int _constituicao;
        private int _vida;
        private static Criatura[] criaturas;

        public int Nivel { get => _nivel; set => _nivel = value; }
        public string Classe { get => _classe; set => _classe = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Forca { get => _forca; set => _forca = value; }
        public int Destreza { get => _destreza; set => _destreza = value; }
        public int Constituicao { get => _constituicao; set => _constituicao = value; }
        public int Vida { get => _vida; set => _vida = value; }
        public Criatura[] Criaturas { get => criaturas; set => criaturas = value; }

        public int Combate()
        {
            return 0;
        }

        public int[] RolaDado(int TipoDeDado, int QuantidadeRolagem)
        {
            Random random = new Random();
            int[] dados = new int[QuantidadeRolagem];

            for (int i = 0; i < dados.Length; i++)
            {
                int num = random.Next(1, TipoDeDado);
                dados[i] = num;
            }
            return dados;
        }
    }
}
