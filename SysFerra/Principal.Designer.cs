namespace SysFerra
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAbrir = new Button();
            txtRuta = new TextBox();
            dgvLista = new DataGridView();
            progressBar1 = new ProgressBar();
            lblcolumnas = new Label();
            txtBuscar = new TextBox();
            chbCodigo = new CheckBox();
            label1 = new Label();
            lblFilasMostradas = new Label();
            lblVacio = new Label();
            txtPorcentaje = new TextBox();
            btnVerArchivo = new Button();
            label2 = new Label();
            label3 = new Label();
            cbxPagina = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.LightGray;
            btnAbrir.FlatStyle = FlatStyle.Popup;
            btnAbrir.Location = new Point(34, 16);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(107, 39);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir y Cargar";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(184, 32);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(471, 23);
            txtRuta.TabIndex = 1;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(34, 114);
            dgvLista.Name = "dgvLista";
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(621, 228);
            dgvLista.TabIndex = 2;
            dgvLista.CellDoubleClick += dgvLista_CellDoubleClick;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = SystemColors.ControlDarkDark;
            progressBar1.Location = new Point(34, 348);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(621, 23);
            progressBar1.TabIndex = 3;
            // 
            // lblcolumnas
            // 
            lblcolumnas.AutoSize = true;
            lblcolumnas.ForeColor = SystemColors.ButtonHighlight;
            lblcolumnas.Location = new Point(365, 374);
            lblcolumnas.Name = "lblcolumnas";
            lblcolumnas.Size = new Size(38, 15);
            lblcolumnas.TabIndex = 4;
            lblcolumnas.Text = "label1";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(120, 85);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(213, 23);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // chbCodigo
            // 
            chbCodigo.AutoSize = true;
            chbCodigo.ForeColor = SystemColors.ButtonFace;
            chbCodigo.Location = new Point(339, 88);
            chbCodigo.Name = "chbCodigo";
            chbCodigo.Size = new Size(84, 19);
            chbCodigo.TabIndex = 6;
            chbCodigo.Text = "Por codigo";
            chbCodigo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(58, 85);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 7;
            label1.Text = "Buscar";
            // 
            // lblFilasMostradas
            // 
            lblFilasMostradas.AutoSize = true;
            lblFilasMostradas.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFilasMostradas.ForeColor = SystemColors.ButtonFace;
            lblFilasMostradas.Location = new Point(588, 85);
            lblFilasMostradas.Name = "lblFilasMostradas";
            lblFilasMostradas.Size = new Size(15, 17);
            lblFilasMostradas.TabIndex = 8;
            lblFilasMostradas.Text = "0";
            // 
            // lblVacio
            // 
            lblVacio.AutoSize = true;
            lblVacio.BackColor = Color.Transparent;
            lblVacio.ForeColor = SystemColors.ButtonFace;
            lblVacio.Location = new Point(270, 219);
            lblVacio.Name = "lblVacio";
            lblVacio.Size = new Size(148, 15);
            lblVacio.TabIndex = 9;
            lblVacio.Text = "No hay Datos Para Mostrar";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(34, 398);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(68, 23);
            txtPorcentaje.TabIndex = 10;
            // 
            // btnVerArchivo
            // 
            btnVerArchivo.Location = new Point(300, 411);
            btnVerArchivo.Name = "btnVerArchivo";
            btnVerArchivo.Size = new Size(88, 27);
            btnVerArchivo.TabIndex = 11;
            btnVerArchivo.Text = "Ver Archivo";
            btnVerArchivo.UseVisualStyleBackColor = true;
            btnVerArchivo.Click += btnVerArchivo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(35, 380);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 12;
            label2.Text = "Porcentaje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(243, 374);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 13;
            label3.Text = "Filas totales cargadas:";
            // 
            // cbxPagina
            // 
            cbxPagina.AutoSize = true;
            cbxPagina.CheckAlign = ContentAlignment.TopCenter;
            cbxPagina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPagina.ForeColor = SystemColors.ButtonFace;
            cbxPagina.Location = new Point(523, 382);
            cbxPagina.Name = "cbxPagina";
            cbxPagina.Size = new Size(132, 39);
            cbxPagina.TabIndex = 14;
            cbxPagina.Text = "Cargar en Pagina";
            cbxPagina.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(688, 450);
            Controls.Add(cbxPagina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPorcentaje);
            Controls.Add(lblVacio);
            Controls.Add(lblFilasMostradas);
            Controls.Add(label1);
            Controls.Add(chbCodigo);
            Controls.Add(txtBuscar);
            Controls.Add(lblcolumnas);
            Controls.Add(progressBar1);
            Controls.Add(dgvLista);
            Controls.Add(txtRuta);
            Controls.Add(btnAbrir);
            Controls.Add(btnVerArchivo);
            Name = "Principal";
            Text = "Principal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrir;
        private TextBox txtRuta;
        private DataGridView dgvLista;
        private ProgressBar progressBar1;
        private Label lblcolumnas;
        private TextBox txtBuscar;
        private CheckBox chbCodigo;
        private Label label1;
        private Label lblFilasMostradas;
        private Label lblVacio;
        private TextBox txtPorcentaje;
        private Button btnVerArchivo;
        private Label label2;
        private Label label3;
        private CheckBox cbxPagina;
    }
}
