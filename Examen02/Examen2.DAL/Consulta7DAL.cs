using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta7DAL
    {

        public DataTable Consulta7()
        {
            string consulta = "SELECT C.IDCLIENTE, P.NOMBRE + ' ' + P.APELLIDO AS NOMBRE_COMPLETO, SUM(V.TOTAL) AS TOTAL_INGRESOS " +
                               " FROM CLIENTE C" +
                               " INNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA" +
                               " INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE" +
                               " GROUP BY C.IDCLIENTE, P.NOMBRE, P.APELLIDO";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }

    }
}
