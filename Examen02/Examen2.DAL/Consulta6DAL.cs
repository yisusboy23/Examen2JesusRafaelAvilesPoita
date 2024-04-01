using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta6DAL
    {
        public DataTable Consulta6()
        {
            string consulta = " SELECT VENTA.IDVENTA, USUARIO.NOMBREUSER, PRODUCTO.NOMBRE, DETALLEING.CANTIDAD " +
                               " FROM PRODUCTO INNER JOIN" +
                               " DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO CROSS JOIN" +
                               " VENTA INNER JOIN" +
                               " USUARIO ON VENTA.IDVENDEDOR = USUARIO.IDUSUARIO";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }

    }
}
