using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta4DAL
    {
        public DataTable Consulta4()
        {
            string consulta = " SELECT SUM(UNIDAD) AS CantidadTotalEnInventario " +
                               " FROM PRODUCTO";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
