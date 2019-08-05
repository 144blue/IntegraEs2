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
using BlocNotasToDatagridview;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        
        List<string> lines  = new List<string>();
        string path = Environment.CurrentDirectory+ "\\new.txt";
            //"C:\\Users\\1007012304\\Desktop\\IntegraEs2-master\\Actividad1\\Actividad1\\new.txt";
       
        Leer l = new Leer();

        public Form1()
        {
            InitializeComponent();
            lines.Add("Nombre,Cedula,Placa,codigo");
            ArrayList gente = new ArrayList();
        }


        private void BtGuardar_Click(object sender, EventArgs e)
        {
            Persona person = new Persona(TbNombree.Text, TbCedulaa.Text, TbPlacaaa.Text, TbCodigo.Text);

            
            string texto = person.Nombre1 + "," + person.Cedula1 + "," + person.Placa1 + "," + person.Codigo1;
            lines.Add(texto);
         
            if (!File.Exists(path)){
                File.CreateText(path);
            }

            
            using (StreamWriter writer = new StreamWriter(path))
            {

                lines.ForEach(delegate (String name)
                {
                    writer.WriteLine(name);
                });
                
                
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.lecturaArchivo(tabla, ',', path);
        }
    }
}
