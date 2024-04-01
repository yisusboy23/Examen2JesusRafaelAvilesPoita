using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta10DAL
    {
        public DataTable Consulta10()
        {
            string consulta = "SELECT P.NOMBRE + ' ' + P.APELLIDO AS NOMBRE_COMPLETO," +
                               " SUM(V.TOTAL) AS Total_Compras" +
                               " FROM CLIENTE C" +
                               " INNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA" +
                               " INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE" +
                               " GROUP BY C.IDCLIENTE, P.NOMBRE, P.APELLIDO" +
                               " HAVING SUM(V.TOTAL) > 200;";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
