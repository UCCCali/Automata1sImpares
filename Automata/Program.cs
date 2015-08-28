using System;

namespace Automata
{
    /// <summary>
    /// Universidad Cooperativa de Colombia
    /// Facultad de Ingenieria
    /// Programa Ing. de Sistemas
    /// Juan Guillermo Gómez
    /// 28/08/2015
    /// 
    /// Descripción: Automata que reconoce cadenas con numeros impares de '1' del alfabteo {0,1}
    /// 
    /// </summary>
    class Automata
    {

        static int cont;
        static char[] caracteres;
        static bool aceptado = false;

        static void Main(string[] args)
        {
            Automata objAutomata = new Automata();
            String cadena = "010110111";
            caracteres = cadena.ToCharArray();
            objAutomata.inicio();
        }

        public void inicio()
        {
            cont = 0;
            aceptado = false;
            q0();
            Console.ReadLine();
        }

        /// <summary>
        /// Estado q0
        /// </summary>
        public void q0()
        {
            Console.WriteLine("En q0");

            if (cont < caracteres.Length)
            {                

                if (caracteres[cont] == '0')
                {
                    cont++;
                    q0();
                }
                else if (caracteres[cont] == '1')
                {
                    cont++;
                    q1();
                }
            }
        }

        /// <summary>
        /// Estado q1
        /// </summary>
        public void q1()
        {
            Console.WriteLine("En q1 Aceptado");

            if (cont < caracteres.Length)
            {            
                aceptado = true;

                if (caracteres[cont] == '0')
                {
                    cont++;                    
                    q1();
                }
                else if (caracteres[cont] == '1')
                {
                    cont++;
                    q0();
                }
            }
        }
       

    }
}
