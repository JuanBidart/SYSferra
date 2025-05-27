namespace SysFerra
{
    partial class Mostrar_Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbxImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // pbxImagen
            // 
            pbxImagen.BackColor = Color.Transparent;
            pbxImagen.Location = new Point(12, 12);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(286, 281);
            pbxImagen.TabIndex = 0;
            pbxImagen.TabStop = false;
            // 
            // Mostrar_Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(309, 303);
            Controls.Add(pbxImagen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mostrar_Producto";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OK";
            TransparencyKey = Color.WhiteSmoke;
            Load += Mostrar_Producto_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxImagen;
    }
}