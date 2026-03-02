using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace JoseEspinoza_Proyecto_Cadenas
{
    /// <summary>
    /// Clase que proporciona herramientas estáticas para la manipulación avanzada de cadenas.
    /// </summary>
    /// <remarks>
    /// Esta clase permite realizar desde extracciones básicas hasta comparaciones interactivas 
    /// con el usuario utilizando cuadros de diálogo de Visual Basic.
    /// </remarks>
    internal class Palabra
    {
        /// <summary>
        /// Extrae el primer y el último carácter de una cadena de texto.
        /// </summary>
        /// <param name="palabra">La cadena de entrada que se va a procesar.</param>
        /// <returns>Una cadena formateada indicando los caracteres extremos encontrados.</returns>
        public static string PrimeraLetrayFinal(string palabra)
        {
            // Usamos Substring para obtener rangos específicos: (inicio, longitud)
            return $"La primera letra es: {palabra.Substring(0, 1)} La ultima letra es: {palabra.Substring(palabra.Length - 1)}";
        }

        /// <summary>
        /// Invierte el orden de los caracteres de la palabra proporcionada.
        /// </summary>
        /// <param name="palabra">La palabra que se desea voltear.</param>
        /// <returns>La palabra escrita al revés con un mensaje de encabezado.</returns>
        public static string imprimirAlreves(string palabra)
        {
            // Convertimos a array para usar el método Reverse de la clase Array
            char[] letras = palabra.ToCharArray();
            Array.Reverse(letras);
            palabra = new string(letras); // Reconstruimos el string
            return "La palabra al revés es: " + palabra;
        }

        /// <summary>
        /// Desglosa la cadena carácter por carácter de forma vertical.
        /// </summary>
        /// <param name="palabra">Cadena de texto a desglosar.</param>
        /// <returns>Un string donde cada letra está seguida por un salto de línea del sistema.</returns>
        public static string ImprimeLetraPorLetra(string palabra)
        {
            string resultado = "";
            // Recorremos la colección de caracteres directamente
            foreach (char letra in palabra)
            {
                resultado += letra + Environment.NewLine;
            }
            return resultado;
        }

        /// <summary>
        /// Desglosa la cadena de forma vertical empezando desde el último carácter.
        /// </summary>
        /// <param name="palabra">Cadena de texto a procesar.</param>
        /// <returns>La secuencia de letras invertida verticalmente.</returns>
        public static string ImprimeLetraPorLetraInverso(string palabra)
        {
            string impresionLetraporLetraInverso = "";
            // Usamos un bucle for inverso basado en el índice de la cadena
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                impresionLetraporLetraInverso += palabra[i] + Environment.NewLine;
            }
            return impresionLetraporLetraInverso;
        }

        /// <summary>
        /// Solicita al usuario una posición y devuelve la letra ubicada en ese índice.
        /// </summary>
        /// <remarks>
        /// Implementa una validación robusta:
        /// 1. Verifica si la entrada es nula o vacía.
        /// 2. Controla excepciones de formato (si el usuario ingresa letras en lugar de números).
        /// 3. Valida que el número esté dentro del rango real de la palabra (1 a Longitud).
        /// </remarks>
        /// <param name="palabra">La palabra fuente donde se buscará la posición.</param>
        /// <returns>Mensaje con la letra encontrada en la posición seleccionada.</returns>
        public static string posicionLetra(string palabra)
        {
            bool numeroCorrecto = false;
            int posicion = 0;

            do
            {
                string input = Interaction.InputBox("Introduce un número", "Buscador de Posición");

                // Validación de cancelación o entrada vacía
                if (string.IsNullOrEmpty(input))
                {
                    return "Operación cancelada por el usuario.";
                }

                try
                {
                    posicion = Convert.ToInt32(input);
                    // Validamos que el índice sea humano (empezando en 1)
                    if (posicion > 0 && posicion <= palabra.Length)
                    {
                        numeroCorrecto = true;
                    }
                    else
                    {
                        MessageBox.Show($"Error: El número debe estar entre 1 y {palabra.Length}");
                        numeroCorrecto = false;
                    }
                }
                catch (FormatException)
                {
                    numeroCorrecto = false;
                    MessageBox.Show("Error: Por favor, introduce un valor estrictamente numérico.");
                }
            }
            while (!numeroCorrecto);

            // Restamos 1 porque los índices en programación empiezan en 0
            char letra = palabra[posicion - 1];
            return "La letra en la posición " + posicion + " es: " + letra;
        }

        /// <summary>
        /// Compara la igualdad de la palabra actual con una nueva entrada solicitada al usuario.
        /// </summary>
        /// <param name="palabra">La palabra original almacenada en el sistema.</param>
        /// <returns>Resultado de la comparación indicando si son idénticas o no.</returns>
        public static string CompararPalabras(string palabra)
        {
            string mensajeResultado;
            string palabraComparar;

            // Bucle para obligar al usuario a ingresar un texto de comparación
            do
            {
                palabraComparar = Interaction.InputBox("Introduce la palabra para comparar:", "COMPARAR");

                if (string.IsNullOrEmpty(palabraComparar))
                {
                    MessageBox.Show("Campo obligatorio: Debes ingresar una palabra.");
                }
            } while (string.IsNullOrEmpty(palabraComparar));

            // Equals realiza una comparación de contenido (Case Sensitive por defecto)
            if (palabra.Equals(palabraComparar))
            {
                mensajeResultado = "¡Éxito! Las palabras son idénticas.";
            }
            else
            {
                mensajeResultado = "Aviso: Las palabras son diferentes.";
            }
            return mensajeResultado;
        }
    }
}