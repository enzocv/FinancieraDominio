using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Repositorios
{
    public interface IRepositorioGeneral<T>
    {
        IList<T> Listar(params object[] ao_parametros);
        T Buscar(params object[] ao_parametros);

        void Insertar(T ao_objeto);
        void GuardarCambios();

    }
}
