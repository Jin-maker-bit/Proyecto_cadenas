using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseEspinoza_Proyecto_Cadenas
{
    internal class Texto
    {
        public static int contarPalabras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return 0;
            string[] palabras = texto.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
        public static int contarVocales(string texto)
        {
            int contador = 0;
            string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";

            foreach (char vocalContar in texto)
            {
                if (vocales.Contains(vocalContar.ToString())) contador++;
            }
            return contador;
        }

        public static int contarConsonantes(string texto)
        {
            int contador = 0;
            string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";

            foreach (char contarCons in texto)
            {
                if (char.IsLetter(contarCons) && !vocales.Contains(contarCons.ToString()))
                {
                    contador++;
                }
            }
            return contador;
        }

        public static string imprimirPalabraxPalabra(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return "";
            string[] palabras = texto.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join("\r\n ", palabras);
        }

        public static string imprimePalabraxPalabraInverso(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return "";
            string[] palabras = texto.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(palabras);
            return string.Join("\r\n", palabras);
        }
        public static string mapaVocales(string texto)
        {
            string resultado = "";
            string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";

            foreach (char c in texto)
            {
                if (vocales.Contains(c.ToString()) || char.IsWhiteSpace(c)) 
                {
                    resultado += c;
                }
                else
                {
                    resultado += " ";
                }
            }
            return resultado;
        }


        public static string mapaConsonantes(string texto)
        {
            string resultado = "";
            string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";

            foreach (char c in texto)
            {
                if (char.IsLetter(c) && !vocales.Contains(c.ToString()))
                {
                    resultado += c;
                }
                else if (char.IsWhiteSpace(c))
                {
                    resultado += " ";
                }
                else
                {
                    resultado += " ";
                }
            }
            return resultado;
        }
    }
}
