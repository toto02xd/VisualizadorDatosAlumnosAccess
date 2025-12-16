using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConexion2
{
    internal class Class1
    {
        public OleDbConnection conexionBaseAlumnos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatosPersonales.accdb");

        public void abrirConexionAlumno()
        {
            try
            {
                conexionBaseAlumnos.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar base de datos");
                throw;
            }
        }

        public void cerrarConexionAlmno()
        {
            try
            {
                conexionBaseAlumnos.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
