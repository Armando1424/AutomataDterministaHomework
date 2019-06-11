using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AutomataDterministaHomework
{

    //Miguel Anguel Jacobo Jacobo
    //Jose Manuel Mejia Martinez
    //Fecha: 14-Mar-18
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((Procesar(txtCapturar.Text) == 1) || (Procesar(txtCapturar.Text) == 2))
            {
                lblMostrar.Text = "Cadena Aceptada";
            }
            else
            {
                lblMostrar.Text = "Cadena No haceptada";
            }
        }

        private static int Procesar(string word)
        {
            int estado = 0;
            char current;
            for (int i = 0; i < word.Length; i++)
            {
                current = word[i];
                switch (estado)
                {
                    case 0:
                        if (current=='a')
                        {
                            estado = 1;
                        }
                        else
                        {
                            estado = 2;
                        }
                        break;
                    case 1:
                        if (current == 'a')
                        {
                            estado = 0;
                        }
                        else
                        {
                            estado = 2;
                        }
                        break;
                    case 2:
                        if (current == 'a')
                        {
                            estado = 1;
                        }
                        else
                        {
                            estado = 0;
                        }
                        break;
                }
            }
            return estado;
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            Cifrado x = new Cifrado();
            x.IniciarAES("LlaveSimetrica");

            lblCifrado.Text = x.Cifrar(txtCaptar.Text);
            lblDessifrado.Text = x.Decifrar(lblCifrado.Text);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnCifrar.Visible = false;
            txtCaptar.Visible = false;
            lblCifrado.Visible = false;
            lblDessifrado.Visible = false;
        }

        private void btnThinks_Click(object sender, EventArgs e)
        {
            btnCifrar.Visible = true;
            txtCaptar.Visible = true;
            lblCifrado.Visible = true;
            lblDessifrado.Visible = true;
        }
    }
}
