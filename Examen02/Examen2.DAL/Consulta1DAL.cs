using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.DAL
{
    public class Consulta1DAL
    {
        public DataTable Consulta1()
        {
            string consulta = " SELECT (PERSONA.NOMBRE+' ' +PERSONA.APELLIDO) NOMBRECOMPLETO , CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE " +
                               " FROM CLIENTE INNER JOIN" +
                               " PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";


            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
