using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Categoria
    {
        D_Categoria objDato = new D_Categoria();

        public List<E_Categoria> listandoCategoria (string buscar)
        {
            return objDato.listarCategoria(buscar);
        }
    }
}
