﻿namespace Distribuidora
{
    partial class Egresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egresos));
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblmonto = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(247, 134);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(265, 22);
            this.dtpfecha.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitulo.Location = new System.Drawing.Point(363, 28);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(132, 36);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Egresos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(665, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfecha.Location = new System.Drawing.Point(155, 134);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(75, 24);
            this.lblfecha.TabIndex = 12;
            this.lblfecha.Text = "Fecha ";
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.BackColor = System.Drawing.Color.Transparent;
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmonto.Location = new System.Drawing.Point(155, 190);
            this.lblmonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(68, 24);
            this.lblmonto.TabIndex = 13;
            this.lblmonto.Text = "Monto";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(247, 190);
            this.txtmonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(188, 22);
            this.txtmonto.TabIndex = 14;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnombre.Location = new System.Drawing.Point(155, 263);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(121, 24);
            this.lblnombre.TabIndex = 17;
            this.lblnombre.Text = "Descripción";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(293, 265);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 22);
            this.txtDescripcion.TabIndex = 18;
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(159, 418);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(140, 74);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.Location = new System.Drawing.Point(516, 418);
            this.btnconfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(133, 74);
            this.btnconfirmar.TabIndex = 20;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 577);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.dtpfecha);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Egresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egresos";
            this.Load += new System.EventHandler(this.Egresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnconfirmar;
    }
}