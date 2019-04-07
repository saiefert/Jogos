using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons
{
    public interface IControladora
    {
        int[] RolaDado(int TipoDeDado, int QuantidadeRolagem);

        int Combate();
    }
}
