namespace Distribuidora
{
    partial class Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos));
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.lblmonto = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.Location = new System.Drawing.Point(357, 340);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(100, 60);
            this.btnconfirmar.TabIndex = 32;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(89, 340);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(105, 60);
            this.btncancelar.TabIndex = 31;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(155, 237);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(142, 20);
            this.txtdescripcion.TabIndex = 30;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnombre.Location = new System.Drawing.Point(47, 239);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(98, 18);
            this.lblnombre.TabIndex = 29;
            this.lblnombre.Text = "Descripción";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(155, 193);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(142, 20);
            this.txtmonto.TabIndex = 26;
            this.txtmonto.TextChanged += new System.EventHandler(this.txtmonto_TextChanged);
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.BackColor = System.Drawing.Color.Transparent;
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmonto.Location = new System.Drawing.Point(86, 193);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(56, 18);
            this.lblmonto.TabIndex = 25;
            this.lblmonto.Text = "Monto";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfecha.Location = new System.Drawing.Point(86, 109);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(59, 18);
            this.lblfecha.TabIndex = 24;
            this.lblfecha.Text = "Fecha ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(469, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitulo.Location = new System.Drawing.Point(242, 23);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(114, 29);
            this.lbltitulo.TabIndex = 22;
            this.lbltitulo.Text = "Ingresos";
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(155, 109);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 21;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(155, 147);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(142, 20);
            this.txtcodigo.TabIndex = 33;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(86, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Codigo";
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.dtpfecha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ingresos";
            this.Text = "Ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
    }
}