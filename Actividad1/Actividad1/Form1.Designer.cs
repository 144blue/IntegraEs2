namespace Actividad1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbNombree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCedulaa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPlacaaa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCodigo = new System.Windows.Forms.TextBox();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbNombree
            // 
            this.TbNombree.AccessibleName = "TbNombre";
            this.TbNombree.Location = new System.Drawing.Point(103, 45);
            this.TbNombree.Name = "TbNombree";
            this.TbNombree.Size = new System.Drawing.Size(205, 20);
            this.TbNombree.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula";
            // 
            // TbCedulaa
            // 
            this.TbCedulaa.AccessibleName = "TbCedula";
            this.TbCedulaa.Location = new System.Drawing.Point(103, 83);
            this.TbCedulaa.Name = "TbCedulaa";
            this.TbCedulaa.Size = new System.Drawing.Size(205, 20);
            this.TbCedulaa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AccessibleName = "LbNombre";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // TbPlacaaa
            // 
            this.TbPlacaaa.AccessibleName = "TbPlaca";
            this.TbPlacaaa.Location = new System.Drawing.Point(103, 124);
            this.TbPlacaaa.Name = "TbPlacaaa";
            this.TbPlacaaa.Size = new System.Drawing.Size(205, 20);
            this.TbPlacaaa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AccessibleName = "LbNombre";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo";
            // 
            // TbCodigo
            // 
            this.TbCodigo.AccessibleName = "TbCodigo";
            this.TbCodigo.Location = new System.Drawing.Point(103, 162);
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.Size = new System.Drawing.Size(205, 20);
            this.TbCodigo.TabIndex = 6;
            // 
            // BtGuardar
            // 
            this.BtGuardar.AccessibleName = "BtGuardar";
            this.BtGuardar.Location = new System.Drawing.Point(144, 232);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtGuardar.TabIndex = 8;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 294);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbPlacaaa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbCedulaa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNombree);
            this.Name = "Form1";
            this.Text = "Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNombree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbCedulaa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPlacaaa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbCodigo;
        private System.Windows.Forms.Button BtGuardar;
    }
}

