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
        Graphics g;
        Pen p;

        public Form1()
        {
            InitializeComponent();
        }

        public void reestablecer() {
            textBoxRecta1.Text = "";
            textBoxRecta2.Text = "";

            labelError.Text = "INGRESE DOS RECTAS DE LA FORMA " +
                "\r\n\r\n              y – y1 = m (x – x1)   Ó" +
                "\r\n                   y = mx + b " +
                "\r\n\r\nPARA CALCULAR SU INTERSECCIÓN," +
                "\r\nSI ES NECESARIO REEMPLACE LOS " +
                "\r\n\"-\" POR \"+\" Y VICEVERSA\r\n";
        }

        public void Error() {
            reestablecer();
            labelError.Text = "ERROR: por favor ingrese las rectas de la siguiente forma:" +
                "\r\n\r\n              y – y1 = m(x – x1)   Ó" +
                "\r\n                   y = mx + b ";
        }

        /*
            *metodo validadNumero
            *Parametros: String num
            *
            *valida si num se puede convertir en un numero
            *
            *retorna el string "error" sino se puede volver un numero, retorna num si si se puede convertir
        */

        public String validarNumero(String num) {
            float aux = 0;
            if (float.TryParse(num, out aux))
            {
                return num;
            }
            else {
                return "error";
            }
            
        }
        /*
            *metodo calcularValorIntersecto
            *parametros: String y1, String x1, String pendiente
            *
            *valida si los datos ingresados se pueden convertir a numeros, de ser asi calcula el intersecto con el eje y
            *
            *retorna un string que contiene el intersecto con el eje y
            *
        */
        public String calcularValorIntersecto(String y1, String x1, String pendiente)
        {
            if (validarNumero(y1) == "error" || validarNumero(x1) == "error" || validarNumero(pendiente) == "error")
            {
                return "error";
            }
            else
            {
                float numX1 = float.Parse(x1);
                float numY1 = float.Parse(y1);
                float numPendiente = float.Parse(pendiente);

                float numIntersecto = (numPendiente * numX1) + (-1 * numY1);

                String intersecto = String.Concat("", numIntersecto);

                return intersecto;
            }

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

            if (posicionX < 2 || posicionIgual != 1 ) {
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

            pendiente = pendiente.Replace("+","");
            intersecto = intersecto.Replace("+", "");

            String[] datos = { pendiente, intersecto };

            return datos;
        }


        /*
            *metodo datosPendiente
            *Parametros: String ecuacion
            *
            *valida si el string ecuacion tiene algunos errores, sino busca la pendiente y saca el intersecto con el eje y
            *
            *retorna un vector string que contiene a la pendiente y al interseccto, en caso de algun error el vector tendra dos string con "error"
        */
        public String[] datosPendiente(String ecuacion) {
            // casos posibles: y +- y1 = m(x +- x1) || y +- y1 = mx || y +- y1 = x +- x1 || y +- y1 = 0 || y =  m(x +- x1) || y = x +- x1
            // (otros casos entran en la funcion datosIntercepto)
            Console.WriteLine("holaaaaaa");
            int posicionY = ecuacion.IndexOf("y");
            int posicionX = ecuacion.IndexOf("x");
            int posicionIgual = ecuacion.IndexOf("=");
            int posicionParentesisInicial = ecuacion.IndexOf("(");
            int posicionParentesisFinal = ecuacion.IndexOf(")");
            int tamanioEcuacion = ecuacion.Length;

            Console.WriteLine(ecuacion);

            String y1 = "";
            String x1 = "";
            String pendiente = "";

            Console.WriteLine(ecuacion+" dentro de pendiente");
            
            if (posicionY != 0 || posicionIgual == -1 || (posicionX == -1 && ecuacion[posicionIgual+1] != "0"[0]) || (posicionX != -1 && posicionX < posicionIgual) || posicionIgual == 2 || //validando que exista "y", que exista "x" si m != 0, que exista "=", que "x" este despues del "=", que no se de esto y - = m( x - x1) 
                (ecuacion[posicionY+1] != "+"[0] && ecuacion[posicionY + 1] != "-"[0] && ecuacion[posicionY + 1] != "="[0]) || // validando que despues del "y" este "+", "-" o "="
                (posicionParentesisInicial != -1 && posicionParentesisFinal == -1) || (posicionParentesisInicial == -1 && posicionParentesisFinal != -1) || // validando que no pase y - y1 = m(x - x1    Ó   y - y1 = mx - x1)
                (posicionParentesisInicial != -1 && posicionParentesisInicial+1 != posicionX) ||   // validando que si existe "(", justo antes de x
                (posicionParentesisInicial == -1 && posicionParentesisFinal == -1 && posicionX != tamanioEcuacion-1 && ecuacion[posicionX+1] != "+"[0] && ecuacion[posicionX+1] != "-"[0]) ||  
                (posicionParentesisFinal != -1 && posicionParentesisFinal != tamanioEcuacion-1) ||  // validando que si existe ")", este al final
                (posicionX != -1 && ( ecuacion[posicionX+1] == "-"[0]  || ecuacion[posicionX + 1] == "+"[0] ) && (posicionX+1 == posicionParentesisFinal  || posicionX +1 == tamanioEcuacion-1))  ) // validando que no pase y - y1 = mx -   Ó   y - y1 = m(x - )
            {

                Console.WriteLine(" xd si entra " + ecuacion);
                String[] error = { "error" , "error" };
                return error;
            }

            if (ecuacion[posicionIgual+1] == "("[0] ) // si la ecuacion es de la forma y +- y1 = (x +- x1) le quita los parentedsis
            {
                ecuacion.Replace("(","");
                ecuacion.Replace(")","");
            }

            // obtener y1
            if (ecuacion[posicionY + 1] == "+"[0] || ecuacion[posicionY + 1] == "-"[0])
            {
                y1 = ecuacion.Substring(posicionY + 1, posicionIgual-1);
            }
            else {
                Console.WriteLine(ecuacion+ "y es cerooo");
                y1 = "0";
            }

            // obtener m y x1
            if (ecuacion[posicionIgual+1] != "x"[0]  && ecuacion[posicionIgual + 1] != "0"[0]) {
                
                pendiente = ecuacion.Substring(posicionIgual+1 , posicionParentesisInicial - posicionIgual - 1);

                if (posicionParentesisFinal == tamanioEcuacion - 1) // si tiene parentesis, x1 esta despues de x
                {
                    x1 = ecuacion.Substring( posicionX+1 , tamanioEcuacion - 2 - posicionX  );
                }
                else  // si no tiene parentesis, x1 es 0
                {
                    x1 = "0";
                }

            }
            else{

                if (ecuacion[posicionIgual + 1] == "0"[0]) // si la parte derecha de la igualdad es 0, la pendiente es cero y x1 es 0
                {
                    pendiente = "0";
                    x1 = "0";

                }
                else
                {  // si la parte derecha no tiene pendiente pero no es cero, la pendiente es 1
                    pendiente = "1";

                    if (posicionX == tamanioEcuacion - 1) // si x1 no aparece en la ecuaciones cero.
                    {
                        x1 = "0";
                    }
                    else //si entra aqui es porque x1 esta en la ecuacion, entonces es diferente de cero
                    {
                        x1 = ecuacion.Substring(posicionX + 1, tamanioEcuacion - 1 - posicionX);
                    }
                }

            }

           

            pendiente = pendiente.Replace("+", "");
            x1 = x1.Replace("+", "");
            y1 = y1.Replace("+", "");
            
            Console.WriteLine(ecuacion+"  x1-> "+x1+"  y1-> "+y1+ " pendiente "+ pendiente);

            String intersecto = calcularValorIntersecto(y1, x1, pendiente);

            String[] datos = { pendiente , intersecto};
            return datos;
        }


        /*
            *metodo calcPuntoInterseccion 
            *parametros: float pendiente1, float pendiente2, float intersecto1, float intersecto2
            *
            *con los datos de las rectas pedidos calcula el punto de interseccion entre estas.
            *
            *retorna un vector de flotantes que tiene la coordenada x y coordenada y del punto de interseccion
        */
        public float[] calcPuntoInterseccion(float pendiente1, float pendiente2, float intersecto1, float intersecto2) { 

            float coordendaX = (intersecto2-intersecto1)/(pendiente1-pendiente2);
            float coordenadaY = pendiente1 * coordendaX + intersecto1;

            float[] puntoInterseccion = { coordendaX, coordenadaY };

            return puntoInterseccion;
        }


        /*
            *metodo identificarCasos
            *Parametos: float pendiente1, float intersecto1, float pendiente2, float intersecto2
            *
            *usa los datos de las rectas para identificar si estas son iguales, paralelas, perpendiculares o si se cruzan
            *
            *retorna un string que indica uno de los cuatro casos anteriores
            *
         */
        public String identidicarCaso(float pendiente1, float intersecto1, float pendiente2, float intersecto2) {
            String caso = "";
            if (pendiente1 == pendiente2 ) {
                if (intersecto1 == intersecto2)
                {
                    caso = "iguales";
                }
                else {
                    caso = "paralelas";
                }
            }
            else
            {
                if (pendiente1*pendiente2 == -1)
                {
                    caso = "perpendiculares";
                }
                else
                {
                    caso = "cruzan";
                }
            }

            return caso;
        }

        public void calcularRectas(String ec1, String ec2) {

            //encontrando datos de la recta 1

            String[] datosEc1 = datosIntercepto(ec1);

            if (validarNumero(datosEc1[0]) == "error" || validarNumero(datosEc1[1]) == "error")
            {
                datosEc1 = datosPendiente(ec1);
            }

            //encontrando datos de la recta 2

            String[] datosEc2 = datosIntercepto(ec2);

            Console.WriteLine(ec2+" "+ec1);

            if (validarNumero(datosEc2[0]) == "error" || validarNumero(datosEc2[1]) == "error")
            {
                datosEc2 = datosPendiente(ec2);
            }

            if (validarNumero(datosEc1[0]) == "error" || validarNumero(datosEc1[1]) == "error" || validarNumero(datosEc2[0]) == "error" || validarNumero(datosEc2[1]) == "error")
            {
                Error();
            }
            else
            {
                float[] valoresEc1 = {0,0};
                float[] valoresEc2 = {0,0};

                valoresEc1[0] = float.Parse(datosEc1[0]);
                valoresEc1[1] = float.Parse(datosEc1[1]);
                valoresEc2[0] = float.Parse(datosEc2[0]);
                valoresEc2[1] = float.Parse(datosEc2[1]);

                Console.WriteLine(valoresEc1[0] + "  -> " + datosEc1[0]);

                String caso = identidicarCaso(valoresEc1[0], valoresEc1[1], valoresEc2[0], valoresEc2[1]);


                switch (caso) {
                    case "paralelas":
                        labelError.Text = "Las rectas: \n\t "+ ec1 +" y   \n\t"+ec2+"\n Son paralelas por lo que" +
                            "no tienen punto de intersección";
                        
                        break;
                    case "iguales":
                        labelError.Text = "Las rectas: \n\t " + ec1 + " y    \n\t" + ec2 + "\n Son la misma recta por lo que" +
                            "se intersectan en todos sus puntos";
                        break;
                    case "perpendiculares":
                        float[] puntoInterseccionPerpendicular = { 0,0};
                        puntoInterseccionPerpendicular = calcPuntoInterseccion(valoresEc1[0], valoresEc2[0], valoresEc1[1], valoresEc2[1]);

                        labelError.Text = "Las rectas: \n\t " + ec1 + " y    \n\t" + ec2 + "\n Son perpendiculares y " +
                            "su punto de intersección es\n\t ( " + puntoInterseccionPerpendicular[0] +" , "+puntoInterseccionPerpendicular[1]+" )";
                        break;
                    case "cruzan":
                            float[] puntoInterseccionCruzado = {0,0};
                            puntoInterseccionCruzado = calcPuntoInterseccion(valoresEc1[0], valoresEc2[0], valoresEc1[1], valoresEc2[1]);
                            labelError.Text = "Las rectas: \n\t " + ec1 + " y    \n\t" + ec2 + "\n " +
                            "\t se intersectan en el punto: \n\t ( " + puntoInterseccionCruzado[0] + " , " + puntoInterseccionCruzado[1] + " )";

                        break;
                    default: 
                        Error();
                        break;

                }
            }

        }

      

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            reestablecer();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            String ec1 = textBoxRecta1.Text;
            String ec2 = textBoxRecta2.Text;

            ec1 = recortarString(ec1);
            ec2 = recortarString(ec2);

            calcularRectas(ec1,ec2);
        }
    }
}
