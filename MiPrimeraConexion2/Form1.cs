using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConexion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 conexionAlu = new Class1();
            string buscar = "Select * From Datospersonales";
            OleDbCommand ejecutar = new OleDbCommand(buscar, conexionAlu.conexionBaseAlumnos);
            conexionAlu.abrirConexionAlumno();
            OleDbDataReader respuesta = ejecutar.ExecuteReader();
            while (respuesta.Read())
            {
                dgvDatospersonales.Rows.Add(respuesta["IdAlumnos"], respuesta["Apellido"], respuesta["Nombre"], respuesta["Edad"]);
            }
        }

        private void dgvDatospersonales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

