using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta9DAL
    {

        public DataTable Consulta9()
        {
            string consulta = " SELECT TIPOPROD.NOMBRE AS TIPOPRODUCTO, PRODUCTO.NOMBRE AS PRODUCTO, DETALLEVENTA.CANTIDAD " +
                               " FROM PRODUCTO INNER JOIN" +
                               " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN" +
                               " DETALLEVENTA ON PRODUCTO.IDPRODUCTO = DETALLEVENTA.IDPRODUCTO";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
