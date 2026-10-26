using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Registro_de_alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CONECTAMOS LOS BOONES con sus eventos 
            btnguardar.Click += btnguardar_Click;
            btnmostrar.Click += Btnmostrar_Click;
            btnlimpiar.Click += Btnlimpiar_Click;
            //consultamos los alumnos al abrir la ventana
            Load += Form1_Load;
        }

        private void Btnlimpiar_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btnmostrar_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //validamos que los campos de texto no esten vacios 
            if (string.IsNullOrWhiteSpace(textBoxmatricula.Text) ||
                string.IsNullOrWhiteSpace(textBoxnombre.Text) ||
                string.IsNullOrWhiteSpace(numericUpDown1.Text) ||
                string.IsNullOrWhiteSpace(textBoxgrupo.Text) ||
                string.IsNullOrWhiteSpace(txtespecialidad.Text))
            {
                MessageBox.Show(
                    "Completa todos los campos antes de guardar.",
                    "Datos Incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            try
            {
                using (OleDbConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                            "INSERT INTO Alumnos " +
                            "(Matricula, Nombre, Semestre, Grupo, Especialidad) " +
                            "VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand commando = new OleDbCommand(consulta, conexion))
                    {
                        //con OlDB importa el orden de los parametros 
                        commando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = textBoxmatricula.Text.Trim();
                        commando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = textBoxnombre.Text.Trim();
                        commando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = numericUpDown1.Value;
                        commando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = textBoxgrupo.Text.Trim();
                        commando.Parameters.Add(
                            "?", OleDbType.VarChar, 20
                            ).Value = txtespecialidad.Text.Trim();
                        commando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al guardar el alumno: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }


        private void CargarAlumnos()
        {
            try
            {
                using(OleDbConnection conexion= ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = "SELECT IdAlumno, Matricula, Nombre, Semestre, Grupo, Especialidad FROM Alumnos ORDER BY IdAlumno";
                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvalumnos.DataSource = tabla;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        $"Error al guardar el alumno: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
        }
    }
}
