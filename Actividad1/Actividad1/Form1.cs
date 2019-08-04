using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using System.IO;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayList gente = new ArrayList();
        }


        private void BtGuardar_Click(object sender, EventArgs e)
        {
            Persona person = new Persona(TbNombree.Text, TbCedulaa.Text, TbPlacaaa.Text, TbCodigo.Text);
            string path = "C:\Users\DH\source\repos\Actividad1\new.txt";
            string texto = person.Nombre1 + "-" + person.Cedula1 + "-" + person.Placa1 + "-" + person.Codigo1;
         
            if (!File.Exists(path)){
                File.CreateText(path);
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(texto);
            }

        }
    }
}
