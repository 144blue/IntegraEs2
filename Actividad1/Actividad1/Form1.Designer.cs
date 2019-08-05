namespace Actividad1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // TbNombree
            // 
            this.TbNombree.AccessibleName = "TbNombre";
            this.TbNombree.Location = new System.Drawing.Point(102, 40);
            this.TbNombree.Name = "TbNombree";
            this.TbNombree.Size = new System.Drawing.Size(152, 20);
            this.TbNombree.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula";
            // 
            // TbCedulaa
            // 
            this.TbCedulaa.AccessibleName = "TbCedula";
            this.TbCedulaa.Location = new System.Drawing.Point(102, 78);
            this.TbCedulaa.Name = "TbCedulaa";
            this.TbCedulaa.Size = new System.Drawing.Size(152, 20);
            this.TbCedulaa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AccessibleName = "LbNombre";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // TbPlacaaa
            // 
            this.TbPlacaaa.AccessibleName = "TbPlaca";
            this.TbPlacaaa.Location = new System.Drawing.Point(102, 119);
            this.TbPlacaaa.Name = "TbPlacaaa";
            this.TbPlacaaa.Size = new System.Drawing.Size(152, 20);
            this.TbPlacaaa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AccessibleName = "LbNombre";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo";
            // 
            // TbCodigo
            // 
            this.TbCodigo.AccessibleName = "TbCodigo";
            this.TbCodigo.Location = new System.Drawing.Point(102, 157);
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.Size = new System.Drawing.Size(152, 20);
            this.TbCodigo.TabIndex = 6;
            // 
            // BtGuardar
            // 
            this.BtGuardar.AccessibleName = "BtGuardar";
            this.BtGuardar.Location = new System.Drawing.Point(102, 183);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(148, 23);
            this.BtGuardar.TabIndex = 8;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 107);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TbCedulaa);
            this.splitContainer1.Panel1.Controls.Add(this.BtGuardar);
            this.splitContainer1.Panel1.Controls.Add(this.TbNombree);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.TbCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.TbPlacaaa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabla);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(787, 212);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 9;
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(17, 40);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(445, 137);
            this.tabla.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::Actividad1.Properties.Resources.Logosimbolo_universidad_icesi;
            this.label5.Location = new System.Drawing.Point(259, 4);
            this.label5.MaximumSize = new System.Drawing.Size(100, 100);
            this.label5.MinimumSize = new System.Drawing.Size(250, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 100);
            this.label5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox TbNombree;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox TbCedulaa;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox TbPlacaaa;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox TbCodigo;
        protected System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

