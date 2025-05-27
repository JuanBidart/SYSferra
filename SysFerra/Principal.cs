using System.Text;
using ExcelDataReader;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SysFerra
{
    public partial class Principal : Form
    {
        private string? filePath;
        private List<Productos>? ListaProductos;
        string archivo = ".//Productoscreados.txt";
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblVacio.Visible = false;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = Path.GetFileName(dlg.FileName);
                    filePath = dlg.FileName;
                    cargar();
                }
            }
        }
        private void Lector() { }
        private void cargar()
        {
            try
            {
                if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                {
                    MessageBox.Show("Seleccione un archivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListaProductos = new List<Productos>();

                var enc = CodePagesEncodingProvider.Instance.GetEncoding(1252);
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    int totalFilas = 0;
                    do
                    {
                        totalFilas += reader.RowCount;
                    } while (reader.NextResult());

                    reader.Reset(); // Reiniciar el lector para procesar los datos

                    progressBar1.Maximum = totalFilas;
                    progressBar1.Value = 0;
                    lblcolumnas.Text = "0";

                    int filasProcesadas = 0;

                    do
                    {
                        while (reader.Read())
                        {
                            int cantColumnas = reader.FieldCount;
                            var producto = new Productos();

                            producto.Codigo = reader.IsDBNull(0) ? "null" : reader.GetString(0);
                            producto.Descripcion = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                            producto.UxB = reader.IsDBNull(2) ? "null" : reader.GetString(2);
                            producto.Precio = reader[3] == DBNull.Value ? null : (string.IsNullOrEmpty(reader[3].ToString()) ? null : reader.GetDouble(3));
                            if (cantColumnas>4)
                            {
                                producto.CodBarra = reader.IsDBNull(4) ? null : reader.GetString(4);
                            }
                            
                            

                            ListaProductos.Add(producto);
                            filasProcesadas++;

                            if (filasProcesadas % 50 == 0 || filasProcesadas == totalFilas)
                            {
                                UpdateProgressBar(filasProcesadas);
                                Task.Delay(1); // Permitir que la UI se actualice
                            }
                        }
                    } while (reader.NextResult());
                }
                
                ListaProductos.RemoveAll(x => string.IsNullOrEmpty(x.Codigo) && string.IsNullOrEmpty(x.Descripcion));

                dgvLista.Invoke(new Action(() =>
                {
                    dgvLista.DataSource = ListaProductos;
                    ConfigurarColumnas();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar(int value)
        {
            progressBar1.Value = value;
            lblcolumnas.Text = value.ToString();
        }

        private void ConfigurarColumnas()
        {
            dgvLista.Columns[1].Width = 275; // Producto
            dgvLista.Columns[0].Width = 50;  // Código
            dgvLista.Columns[2].Width = 100; // UxB
            dgvLista.Columns[3].Width = 100; // Costo
            dgvLista.Columns[4].Width = 100; // Cod. Barra
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblVacio.Visible = false;
                string datoIngresado = txtBuscar.Text.ToUpper();

                if (string.IsNullOrEmpty(datoIngresado))
                {
                    dgvLista.DataSource = ListaProductos!.FindAll(x =>
                    x.Descripcion!.Contains("abcdefghijklmnñopqrstuvwxyz0123456789"));
                }

                if (chbCodigo.Checked && datoIngresado != "")
                {
                    dgvLista.DataSource = ListaProductos!.FindAll(x => x.Codigo!.ToUpper() == datoIngresado);
                }
                else
                {
                    dgvLista.DataSource = ListaProductos!.FindAll(x =>
                        x.Descripcion!.ToUpper().Contains(datoIngresado) || x.Codigo!.ToUpper() == datoIngresado);
                }

                int contador = dgvLista.RowCount;
                lblFilasMostradas.Text = contador.ToString();
                if (contador <= 0)
                {

                    lblVacio.Visible = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Productos productoselecionado = new Productos();

                productoselecionado = (Productos)dgvLista.CurrentRow!.DataBoundItem!;

                if (productoselecionado != null & !string.IsNullOrEmpty(txtPorcentaje.Text))
                {
                    double? costo = productoselecionado.Precio;
                    double porcentaje = double.Parse(txtPorcentaje.Text);

                    decimal resultado = (decimal)(costo * (porcentaje / 100 + 1));
                    decimal resultadoredondeado = Math.Round(resultado, 0, MidpointRounding.AwayFromZero);
                    decimal resultadoredondeado2 = Math.Ceiling(resultadoredondeado / 10) * 10;





                    StreamWriter sw = new StreamWriter(archivo, true);

                    sw.WriteLine(productoselecionado.Descripcion + "\r" + productoselecionado.UxB + "\r" + resultado + /* "\r" + resultadoredondeado +*/ "\r" + resultadoredondeado2);
                    sw.WriteLine("----------------------------");
                    sw.Close();

                    Mostrar_Producto mostrar_Producto = new Mostrar_Producto();
                    mostrar_Producto.ShowDialog();

                    if (cbxPagina.Checked == true)
                    {
                        IWebDriver drive = new ChromeDriver();
                        
                        



                    }

                }
                else
                {
                    MessageBox.Show("Cargar porcentaje", "ERROR", default, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {

            try
            {
                if (!File.Exists(archivo))
                {
                    throw new FileNotFoundException();
                }

                // Abrir el archivo en el Bloc de notas
                System.Diagnostics.Process.Start("notepad.exe", archivo);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No hay archivos o no se creó correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar abrir el archivo: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
