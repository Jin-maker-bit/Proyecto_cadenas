using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoseEspinoza_Proyecto_Cadenas
{
    internal class Palabra
    {
        public static string PrimeraLetrayFinal(string palabra)
        {
            char primera = palabra[0];
            char ultima = palabra[palabra.Length - 1];
            return "La primera letra es: " + primera + ". " + " La última letra es: " + ultima;
        }

        public static string imprimirAlreves(string palabra)
        {
            char[] letras = palabra.ToCharArray();
            Array.Reverse(letras);
            palabra = new string(letras);
            return "La palabra al revés es: " + palabra;
        }
        public static string posicionLetra(string palabra, string letraPosicion)
        {
            if (!int.TryParse(letraPosicion, out int posicion))
            {
                return "";
            }

            int indice = posicion - 1;
            if (indice >= 0 && indice < palabra.Length)
            {
                return palabra[indice].ToString();
            }

            return "";
        }
        public static string CompararPalabras(string palabra)
        {
            string segundaPalabra = Interaction.InputBox(
                "Por favor, introduce la segunda palabra a comparar",
                "Comparar palabras",
                "");

            if (string.IsNullOrWhiteSpace(segundaPalabra))
                return "";

            if (string.Equals(palabra.Trim(), segundaPalabra.Trim(), StringComparison.OrdinalIgnoreCase))
                return "Las palabras son iguales";
            else
                return "Las palabras no son iguales";
        }
        public static string ImprimeLetraPorLetra(string palabra)
        {
            string resultado = "";
            foreach (char letra in palabra)
            {
                resultado += letra + "\r\n";
            }
            return resultado;
        }
        public static string ImprimeLetraPorLetraInverso(string palabra)
        {
            string resultado = "";

            char[] vueltaPalabra = palabra.ToCharArray();

            Array.Reverse(vueltaPalabra);
            foreach (char recogemos in vueltaPalabra)
            {
                resultado += recogemos + "\r\n";
            }
            return resultado;
        }
    }

}

