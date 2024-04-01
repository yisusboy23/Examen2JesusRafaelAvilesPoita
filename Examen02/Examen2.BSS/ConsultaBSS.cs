using Examen2.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.BSS
{
    public class ConsultaBSS
    {
        Consulta1DAL c1= new Consulta1DAL();
        Consulta2DAL c2 = new Consulta2DAL();
        Consulta3DAL c3 = new Consulta3DAL();
        Consulta4DAL c4 = new Consulta4DAL();
        Consulta5DAL c5 = new Consulta5DAL();
        Consulta6DAL c6 = new Consulta6DAL();
        Consulta7DAL c7 = new Consulta7DAL();
        Consulta8DAL c8 = new Consulta8DAL();
        Consulta9DAL c9 = new Consulta9DAL();
        Consulta10DAL c10 = new Consulta10DAL();
        public DataTable Consulta1BSS()
        {
            return c1.Consulta1();
        }
        public DataTable Consulta2BSS()
        {
            return c2.Consulta2();
        }
        public DataTable Consulta3BSS()
        {
            return c3.Consulta3();
        }
        public DataTable Consulta4BSS()
        {
            return c4.Consulta4();
        }
        public DataTable Consulta5BSS()
        {
            return c5.Consulta5();
        }
        public DataTable Consulta6BSS()
        {
            return c6.Consulta6();
        }
        public DataTable Consulta7BSS()
        {
            return c7.Consulta7();
        }
        public DataTable Consulta8BSS()
        {
            return c8.Consulta8();
        }
        public DataTable Consulta9BSS()
        {
            return c9.Consulta9();
        }
        public DataTable Consulta10BSS()
        {
            return c10.Consulta10();
        }
    }
}
