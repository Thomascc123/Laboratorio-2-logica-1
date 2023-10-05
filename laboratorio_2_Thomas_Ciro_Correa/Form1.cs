using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio_2_Thomas_Ciro_Correa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
            * metodo recortarString 
            * Parametros: String Texto 
            * 
            * al Texto le quita los espacios y vuelve todas las letras minusculas y cambia los "." por ","
            * 
            * devuelve el String Texto
         */
        public String recortarString(String texto) {
            texto = texto.ToLower();
            texto = texto.Replace(" ","");
            texto = texto.Replace(".",",");

            return texto;
        }

        /*
            *metodo tipoEcuacion 
            *Parametros: String ecuacion
            *
            *valida un tipo de error en ecuacion y si es una ecuacion punto intercepto o punto pendiente
            *
            *devuelve un String que indica que tipo de ecuacion es o si es un error
        */

        public String validarTipoEcuacion(String ecuacion) {

            if (ecuacion[0] != "y"[0])
            {
                return "error";
            }
            else if (ecuacion[1] == "-"[0] || ecuacion[1] == "+"[0])
            {
                return "pendiente";
            }
            else if (ecuacion[1] == "="[0])
            {
                return "intercepto";
            }
            else { 
                return "error";
            }

        }


        /*
            *metodo datosIntercepto
            *Parametros: String ecuacion
            *
            *de la ecuacion saca la posicion de la x y del = y el tamaño, valida que esto este correcto y
            *prueba todos los casos posibles para encontrar la pendiente y el intersecto y los guarda en el 
            *vector datos, si algo falla se llena otro vector con la palabra "error".
            *
            *retorna el vector datos que contiene la pendiente y el intersecto en string o
            *retorna el vector error si se presentan algunos errores
        */
        public String[] datosIntercepto(String ecuacion) {
            // Casos posibles: y = mx + b || y = mx - b || y = mx  || y = -mx + b || y = -mx - b || y = -mx  || y = x || y = -x || y = b || y = -b  

            int posicionX = ecuacion.IndexOf("x");
            int posicionIgual = ecuacion.IndexOf("=");
            int tamanioEcuacion = ecuacion.Length;

            String pendiente = "";
            String intersecto = "";


            if (posicionX < 2 || posicionIgual != 1) {
                String[] error = { "error","error" };
                return error;
            }

            if (posicionX != -1) // entra si la ecuacion tiene x
            {
                // sacar la pendiente
                if (ecuacion[2] == "x"[0])
                {
                    pendiente = "1";
                }
                else if (ecuacion.Substring(2, 2) == "-x")
                {
                    pendiente = "-1";
                }
                else {
                    pendiente = ecuacion.Substring(posicionIgual + 1, posicionX - 1 - posicionIgual);
                }

                //sacar el intersecto
                if (posicionX == tamanioEcuacion - 1) { // entra si no hay intersecto
                    intersecto = "0";
                }
                else
                { 
                    intersecto = ecuacion.Substring(posicionX + 1, tamanioEcuacion - 1 - posicionX);
                }       


            }
            else   // entra si la ecuacion no tiene x
            { 
                int tamanioInterseccion = tamanioEcuacion - posicionIgual;
                pendiente = "0";
                intersecto = ecuacion.Substring(posicionIgual, tamanioInterseccion);
            }
            String[] datos = { pendiente, intersecto };

            return datos;
        }

        public String[] datosPendiente(String ecuacion) {
            // casos posibles: y +- y1 = m(x +- x1) || y +- y1 = mx || y +- y1 = x +- x1 || y +- y1 = 0 || y =  m(x +- x1) || y = x +- x1
            // (los otros casos entran en la otra funcion)

            int posicionY = ecuacion.IndexOf("y");
            int posicionX = ecuacion.IndexOf("x");
            int posicionIgual = ecuacion.IndexOf("=");
            0
            if (posicionY != 0 || posicionIgual == -1 || posicionX == -1 || posicionX < posicionIgual || (ecuacion[1] != "+"[0] && ecuacion[1] != "-"[0] && ecuacion[1] != "="[0]) ) { 
            
            }


            String[] datos = { };
            return datos;
        }

        public float extraerDatos(String ecuacion) {
            ecuacion = recortarString(ecuacion);

            String tipoEcuacion = validarTipoEcuacion(ecuacion);
            switch (tipoEcuacion) {
                case "intercepto":

                    break;
                case "pendiente":

                    break;
                case "error":

                    break;
            }

            return 0;
        }

        private void pruebas_Click(object sender, EventArgs e)
        {
            String ec1 = textBoxRecta1.Text;
            ec1 = recortarString(ec1);

       
   
        }
    }
}
