using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta8DAL
    {
        public DataTable Consulta8()
        {
            string consulta = "SELECT TOP 1\r\n    PR.NOMBRE AS Proveedor,\r\n    COUNT(*) AS Cantidad_Productos\r\nFROM\r\n    PROVEEDOR PR\r\nJOIN\r\n    PROVEE PV ON PR.IDPROVEEDOR = PV.IDPROVEEDOR\r\nGROUP BY\r\n    PR.NOMBRE\r\nORDER BY\r\n    COUNT(*) DESC;";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }


    }
}
