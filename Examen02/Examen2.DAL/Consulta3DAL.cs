using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta3DAL
    {
        public DataTable Consulta3()
        {
            string consulta = " \r\n\r\nSELECT TOP 1\r\n    M.NOMBRE\r\nFROM\r\n    MARCA M\r\nJOIN\r\n    PRODUCTO P ON M.IDMARCA = P.IDMARCA\r\nJOIN\r\n    DETALLEVENTA DV ON P.IDPRODUCTO = DV.IDPRODUCTO\r\nGROUP BY\r\n    M.NOMBRE\r\nORDER BY\r\n    COUNT(*) DESC;";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
