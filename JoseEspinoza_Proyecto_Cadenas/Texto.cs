using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseEspinoza_Proyecto_Cadenas
{
    /// <summary>
    /// Proporciona métodos estáticos para el análisis y procesamiento de bloques de texto.
    /// </summary>
    /// <remarks>
    /// Esta clase incluye funciones para conteo de caracteres, limpieza de símbolos de puntuación
    /// y generación de mapas visuales de vocales y consonantes.
    /// </remarks>
    internal class Texto
    {
        /// <summary>
        /// Cuenta el número total de vocales presentes en un texto, incluyendo mayúsculas y acentuadas.
        /// </summary>
        /// <param name="texto">El bloque de texto a analizar.</param>
        /// <returns>La cantidad total de vocales encontradas como un valor entero.</returns>
        public static int contarVocales(string texto)
        {
            int contador = 0;
            string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";

            for (int i = 0; i < texto.Length; i++)
            {
                if (vocales.Contains(texto[i]))
                {
                    contador++;
                }
            }
            return contador;
        }

        /// <summary>
        /// Cuenta el número total de consonantes presentes, ignorando vocales, espacios y símbolos.
        /// </summary>
        /// <param name="texto">El texto a analizar.</param>
        /// <returns>La cantidad de consonantes (incluyendo la ñ).</returns>
        public static int contarConsonantes(string texto)
        {
            string consonantes = "bcdfghjklmnñpqrstvwxyzBCDFGHJKLMNÑPQRSTVWXYZ";
            int contador = 0;
            foreach (char c in texto)
            {
                if (consonantes.Contains(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        /// <summary>
        /// Calcula la cantidad de palabras en un texto basándose en los espacios en blanco.
        /// </summary>
        /// <param name="texto">El texto a procesar.</param>
        /// <returns>El número de elementos obtenidos tras dividir la cadena por espacios.</returns>
        public static int contarPalabras(string texto)
        {
            int contador;
            string[] palabras = texto.Trim().Split(' ');
            contador = palabras.Length;
            return contador;
        }

        /// <summary>
        /// Limpia el texto de símbolos de puntuación y devuelve cada palabra en una línea nueva.
        /// </summary>
        /// <remarks>
        /// El método utiliza un arreglo de caracteres especiales para filtrar el texto original
        /// mediante el método <see cref="string.Replace(string, string)"/> antes de la división.
        /// </remarks>
        /// <param name="texto">El texto original con posible puntuación.</param>
        /// <returns>Una cadena con palabras limpias separadas por saltos de línea.</returns>
        public static string imprimirPalabraxPalabra(string texto)
        {
            char[] simbolos = {
                '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+',
                ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@',
                '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~',
                '¡', '¿', '€', '¬'
            };
            for (int i = 0; i < texto.Length; i++)
            {
                if (simbolos.Contains(texto[i]))
                {
                    texto = texto.Replace(texto[i].ToString(), "");
                }
            }
            string resultado = "";
            string[] palabras = texto.Trim().Split(' ');
            foreach (string palabra in palabras)
            {
                resultado += palabra + Environment.NewLine;
            }
            return resultado;
        }

        /// <summary>
        /// Limpia el texto de símbolos y devuelve las palabras en orden inverso (de última a primera).
        /// </summary>
        /// <param name="texto">El texto a procesar.</param>
        /// <returns>Las palabras del texto en orden invertido, una por línea.</returns>
        public static string imprimirPalabraxPalabraInverso(string texto)
        {
            char[] simbolos = {
                '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+',
                ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@',
                '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~',
                '¡', '¿', '€', '¬'
            };
            for (int i = 0; i < texto.Length; i++)
            {
                if (simbolos.Contains(texto[i]))
                {
                    texto = texto.Replace(texto[i].ToString(), "");
                }
            }
            string resultado = "";
            string[] palabras = texto.Trim().Split(' ');
            Array.Reverse(palabras);
            foreach (string palabra in palabras)
            {
                resultado += palabra + Environment.NewLine;
            }
            return resultado;
        }

        /// <summary>
        /// Genera una "máscara" del texto donde solo permanecen visibles las vocales.
        /// </summary>
        /// <remarks>
        /// Crea un nuevo arreglo de caracteres del mismo tamaño que el texto original,
        /// sustituyendo cualquier carácter que no sea vocal por un espacio en blanco.
        /// </remarks>
        /// <param name="texto">El texto a enmascarar.</param>
        /// <returns>Un string con las vocales en su posición original y espacios en el resto.</returns>
        public static string mapaVocales(string texto)
        {
            string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";
            char[] resultado = new char[texto.Trim().Length];

            for (int i = 0; i < texto.Trim().Length; i++)
            {
                if (vocales.Contains(texto[i]))
                {
                    resultado[i] = texto[i];
                }
                else
                {
                    resultado[i] = ' ';
                }
            }
            return new string(resultado);
        }

        /// <summary>
        /// Genera una "máscara" del texto donde solo permanecen visibles las consonantes.
        /// </summary>
        /// <remarks>
        /// Sigue la misma lógica que el mapa de vocales, pero filtra utilizando 
        /// una cadena de consonantes predefinida.
        /// </remarks>
        /// <param name="texto">El texto a enmascarar.</param>
        /// <returns>Un string con las consonantes en su posición original y espacios en el resto.</returns>
        public static string mapaConsonantes(string texto)
        {
            string consonantes = "bcdfghjklmnñpqrstvwxyzBCDFGHJKLMNÑPQRSTVWXYZ";
            char[] resultado = new char[texto.Trim().Length];

            for (int i = 0; i < texto.Trim().Length; i++)
            {
                if (consonantes.Contains(texto[i]))
                {
                    resultado[i] = texto[i];
                }
                else
                {
                    resultado[i] = ' ';
                }
            }
            return new string(resultado);
        }
    }
}