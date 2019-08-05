using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BlocNotasToDatagridview
{
    

    class Leer
    {
       
        public void lecturaArchivo(DataGridView tabla, char caracter, string ruta)
        {
            StreamReader objReader = new StreamReader(ruta);
            string sLine = "";
            int fila = 0;
            tabla.Rows.Clear();
            tabla.AllowUserToAddRows = false;

            do
            {
                sLine = objReader.ReadLine();
                if ((sLine != null))
                {
                    if (fila == 0)
                    {
                        tabla.ColumnCount = 4;
                        nombrarTitulo(tabla, sLine.Split(caracter));
                        fila += 1;
                    }
                    else
                    {
                        agregarFilaDatagridview(tabla, sLine, caracter);
                        fila += 1;
                    }

                }
            } 
            
            while (!(sLine == null));
            objReader.Close();
        }


        public static void nombrarTitulo(DataGridView tabla, string[] titulos)
        {
            int x = 0;
            for (x = 0; x <= tabla.ColumnCount - 1; x++)
            {
                tabla.Columns[x].HeaderText = titulos[x];
            }
        }

        
        public static void agregarFilaDatagridview(DataGridView tabla, string linea,char caracter)
        {
            string[] arreglo = linea.Split(caracter);
            tabla.Rows.Add(arreglo);
        }

    }
}
