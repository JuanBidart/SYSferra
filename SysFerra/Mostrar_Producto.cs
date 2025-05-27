using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SysFerra
{
    public partial class Mostrar_Producto : Form
    {
        private Timer? timer;

        public Mostrar_Producto()
        {
            InitializeComponent();
        }

        private void Mostrar_Producto_Load(object sender, EventArgs e)
        {
            // Configuración del PictureBox
            pbxImagen.Load(".//ok.png");
            pbxImagen.BackColor = Color.Transparent; // Fondo transparente
            pbxImagen.BorderStyle = BorderStyle.None; // Sin bordes
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar la imagen al tamaño del PictureBox

            // Configuración del Timer
            timer = new Timer();
            timer.Interval = 1000; // 2000 ms = 2 segundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Detener el Timer y cerrar el formulario
            timer.Stop();
            timer.Dispose();
            this.Close();
        }
    }
}
