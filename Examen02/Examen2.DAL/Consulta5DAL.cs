using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta5DAL
    {
        public DataTable Consulta5()
        {
            string consulta ="SELECT P.NOMBRE AS NOMBRE_PRODUCTO, D.FECHAVENC AS FECHA_EXPIRACION\r\nFROM DETALLEING D\r\nINNER JOIN PRODUCTO P ON D.IDPRODUCTO = P.IDPRODUCTO\r\nWHERE D.FECHAVENC <= DATEADD(day, 30, GETDATE())\r\nORDER BY D.FECHAVENC DESC;";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
