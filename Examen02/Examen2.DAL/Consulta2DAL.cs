using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta2DAL
    {
        public DataTable Consulta2()
        {
            string consulta = " SELECT pr.NOMBRE AS Proveedor, SUM(i.TOTAL) AS TotalIngresos " +
                               " FROM PROVEEDOR pr" +
                               " INNER JOIN INGRESO i ON pr.IDPROVEEDOR = i.IDPROVEEDOR" +
                               " GROUP BY pr.NOMBRE";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
