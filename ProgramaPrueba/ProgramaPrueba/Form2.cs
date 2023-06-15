using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Drawing;

namespace ProgramaPrueba
{
    public partial class Form2 : Form
    {
        string rutaArchivoExcel = @"C:\Users\ivanc\source\repos\ProgramaPrueba\ejemplo.xlsx"; //Lugar donde esta guardado el libro de excel
        private ExcelPackage package; // Variable para almacenar el paquete de Excel

        public Form2()
        {
            InitializeComponent();
            AbrirArchivoExcel();
        }

        private void AbrirArchivoExcel()
        {
            // Establece el contexto de licencia antes de utilizar EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                // Abre el archivo de Excel utilizando  EPPlus
                package = new ExcelPackage(new FileInfo(rutaArchivoExcel));
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet"];

                int filaInicial = 1;
                int numeroFilas = 5;

                for (int fila = filaInicial; fila < filaInicial + numeroFilas; fila++)
                {
                    string estado = worksheet.Cells[fila, 2].Value?.ToString();

                    string botonName = "button" + (fila - filaInicial + 1);
                    Control[] controles = Controls.Find(botonName, true);
                    if (controles.Length > 0 && controles[0] is Button boton)
                    {
                        boton.BackColor = (estado == "Vacio") ? Color.Green : Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el archivo de Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AbrirArchivoExcel();
        }

        private void GuardarArchivoExcel()
        {
            try
            {
                if (package != null)
                {
                    package.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el archivo de Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(button1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(button2, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(button3, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(button4, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CambiarEstadoBoton(button5, 5);
        }

        private void CambiarEstadoBoton(Button boton, int fila)
        {
            if (boton.BackColor == Color.Green)
            {
                boton.BackColor = Color.Red;
                ActualizarEstadoEnExcel(fila, "Ocupado"); // Cambia
            }
            else
            {
                boton.BackColor = Color.Green;
                ActualizarEstadoEnExcel(fila, "Vacio");
            }

            GuardarArchivoExcel();
        }

        private void ActualizarEstadoEnExcel(int fila, string estado)
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet"];
            worksheet.Cells[fila, 2].Value = estado;
        }
    }
}