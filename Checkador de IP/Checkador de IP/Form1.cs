using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Checkador_de_IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

    }
private void button1_Click(object sender, EventArgs e)
        {
        List<string> ip = new List<string>();

        // Leitura do arquivo

        using (StreamReader reader = new StreamReader(@"C:\Users\55199\Desktop\2º Semestre\Janaine - Linguagem de Programação\Checkador de IP\Checkador de IP\ip.txt")) 
        {
            while(!reader.EndOfStream)
            {
                string linha = reader.ReadLine();

                ip.Add(linha);
            }
        }


    }
    }
    }
}