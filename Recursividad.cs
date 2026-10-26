using System;
using UnityEngine;

public class Recursividad : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int factorial_recursivo(int n)
        {
            // Condición de terminación (Caso Base)
            
            if (n == 1 || n == 0) return 1;

            
            // Llamada recursiva
            
            return n * factorial_recursivo(n - 1);
        }

        // El producto a  b, donde a y b son enteros positivos, se puede definir recursivamente como la suma repetida de a.
        //Caso base: a* b = a si b = 1
        // Caso recursivo: a * b = a + (a *(b - 1)) si b > 1
        
        int producto(int a, int b)
        {
            if (b == 1) return a;
            return a + producto(a, b - 1);
        }

        //La serie comienza con 0 y 1, y cada elemento posterior es la suma de los dos anteriores.
        //La definición recursiva requiere dos llamadas a sí misma por cada iteración:
        
        int fibonacci_recursivo(int n)
        {
            if (n <= 1) return n;
            return fibonacci_recursivo(n - 1) + fibonacci_recursivo(n - 2);
        }

        //Como vimos en el análisis de costes, esta doble llamada genera un árbol exponencial, dándole una complejidad temporal altísima de O(2^n)

        //el código de la búsqueda binaria, que vimos en el tema anterior, pero de manera recursiva. Analiza sus costes, temporal y espacial, y compáralo con su versión iterativa

        // Búsqueda Binaria Recursiva: Coste Temporal O(log n) | Espacial O(log n)
        
        int BusquedaBinariaRecursiva(int[] array, int objetivo, int izquierda, int derecha)
        {
            // Condición de terminación: si los índices se cruzan, el elemento no existe
            if (izquierda > derecha)
            {
                return -1;
            }

            // Calculamos el punto medio
            int medio = izquierda + (derecha - izquierda) / 2;

            // Caso base de éxito: hemos encontrado el elemento
            if (array[medio] == objetivo)
            {
                return medio;
            }

            // Caso recursivo: el objetivo es mayor, buscamos en la mitad derecha
            if (array[medio] < objetivo)
            {
                return BusquedaBinariaRecursiva(array, objetivo, medio + 1, derecha);
            }
            // Caso recursivo: el objetivo es menor, buscamos en la mitad izquierda
            else
            {
                return BusquedaBinariaRecursiva(array, objetivo, izquierda, medio - 1);
            }
        }

        // 1. Contar las cifras de un entero no negativo n
        static int ContarCifras(int n)
        {
            // Caso base: si el número tiene una sola cifra (< 10), ya sabemos que tiene 1 dígito
            if (n < 10)
            {
                return 1;
            }
            else
            {
                // Caso recursivo: quitamos la última cifra (n / 10) y sumamos 1 por la cifra que acabamos de quitar
                // Ejemplo: ContarCifras(1234) → 1 + ContarCifras(123) → 1 + 1 + ContarCifras(12) → ... → 4

                return 1 + ContarCifras(n / 10);
            }
        }

        // 2. Contar las veces que una cifra c aparece en n
        static int ContarCifra(int n, int c)
        {
            // Caso especial: cuando n llega a 0
            if (n == 0)
            {
                // Solo contamos el 0 si estamos buscando el dígito 0
                if (c == 0)
                    return 1;
                else
                    return 0;
            }
            // Caso base: número de una sola cifra
            else if (n < 10)
            {
                return (n == c) ? 1 : 0;
            }
            else
            {
                // Extraemos la última cifra
                int ultima = n % 10;
                // Llamada recursiva sobre el resto del número
                int resto = ContarCifra(n / 10, c);

                // Sumamos 1 si la última cifra coincide con c
                return (ultima == c) ? 1 + resto : resto;
            }
        }

        // 3. Averiguar si todas las cifras de n son pares
        static bool TodasPares(int n)
        {
            // Caso base: número de una sola cifra → comprobamos si es par
            if (n < 10)
            {
                return n % 2 == 0;
            }
            else
            {
                // Si la última cifra es impar → ya sabemos que NO todas son pares
                if ((n % 10) % 2 != 0)
                    return false;
                else
                    // Si es par, seguimos comprobando el resto del número
                    return TodasPares(n / 10);
            }
        }

        // 4. Averiguar si un dato d aparece en un vector no ordenado v
        static bool Aparece(int[] v, int d, int i = 0)
        {
            // Caso base 1: hemos llegado al final del vector sin encontrarlo
            
            if (i >= v.Length)
                return false;
            // Caso base 2: lo encontramos en la posición actual
           
            else if (v[i] == d)
                return true;
            else
                // Caso recursivo: buscamos en la siguiente posición
                return Aparece(v, d, i + 1);
        }

        // 5. Contar las veces que un dato d aparece en un vector no ordenado v
        static int ContarApariciones(int[] v, int d, int i = 0)
        {
            // Caso base: llegamos al final del vector → no hay más apariciones
            if (i >= v.Length)
                return 0;
            else
            {
                // Contamos 1 si el elemento actual es igual a d, 0 en caso contrario
                int cuenta = (v[i] == d) ? 1 : 0;

                // Sumamos la cuenta del resto del vector
                return cuenta + ContarApariciones(v, d, i + 1);
            }
        }

        // 6. Mostrar los elementos de v en orden natural (de izquierda a derecha)
        static void MostrarNatural(int[] v, int i = 0)
        {
            // Caso base: hemos llegado al final del vector
            if (i >= v.Length)
                return;
            else
            {
                // Imprimimos el elemento actual
                Console.WriteLine(v[i]);
                // Seguimos con el siguiente
                MostrarNatural(v, i + 1);
            }
        }

        // 7. Mostrar los elementos de v en orden inverso (de derecha a izquierda)
        static void MostrarInverso(int[] v, int i)
        {
            // Caso base: el índice se ha salido por la izquierda
            if (i < 0)
                return;
            else
            {
                // Imprimimos el elemento actual (empezando desde el final)
                Console.WriteLine(v[i]);
                // Seguimos hacia la izquierda
                MostrarInverso(v, i - 1);
            }
        }
        // Llamada correcta: MostrarInverso(v, v.Length - 1);

        // 8. Averiguar si un vector no vacío v está ordenado de menor a mayor
        static bool EstaOrdenado(int[] v, int i = 0)
        {
            // Caso base: hemos llegado al penúltimo elemento → el vector está ordenado
           
            if (i >= v.Length - 1)
                return true;
           
            // Si encontramos un par desordenado → no está ordenado
           
            else if (v[i] > v[i + 1])
                return false;
            else
              
                // Seguimos comprobando el resto
               
                return EstaOrdenado(v, i + 1);
        }

        // 9. Encontrar el menor elemento en un vector no ordenado y no vacío v
        
        static int Menor(int[] v, int i = 0)
        {
            // Caso base: estamos en el último elemento → ese es el menor del subvector restante
            if (i == v.Length - 1)
                return v[i];
            else
            {
                // Obtenemos el menor del resto del vector
                int menorResto = Menor(v, i + 1);

                // Comparamos el elemento actual con el menor del resto
                return (v[i] < menorResto) ? v[i] : menorResto;
            }
        }

        // 10. Averiguar si todos los elementos de v son mayores que un dato d
        
        static bool TodosMayoresQue(int[] v, int d, int i = 0)
        {
            // Caso base: hemos recorrido todo el vector sin encontrar ninguno ≤ d
            if (i >= v.Length)
                return true;
            
            // Si encontramos un elemento que no es mayor que d → fallamos
           
            else if (v[i] <= d)
                return false;
            else
                
                // Seguimos comprobando el resto
               
                return TodosMayoresQue(v, d, i + 1);
            
        }

        // Función recursiva que suma los elementos de un array
        // Parámetros:
        //   array  → el array de enteros
        //   indice → posición actual desde la que empezamos a sumar
        // Retorna: la suma de todos los elementos desde 'indice' hasta el final
        int SumaArrayRecursiva(int[] array, int indice)
        {
            // ===== CASO BASE =====
            // Si el índice se ha salido del array, no hay más elementos que sumar
            if (indice >= array.Length)
            {
                return 0;   // Devolvemos 0 (elemento neutro de la suma)
            }

            // ===== CASO RECURSIVO =====
            // Sumamos el elemento actual + la suma del resto del array (índice + 1)
            return array[indice] + SumaArrayRecursiva(array, indice + 1);
        }

        // Ejemplo de uso:
        void EjemploUso()
        {
            int[] numeros = { 5, 3, 8, 2, 7 };

            // Llamamos empezando desde el índice 0
            int total = SumaArrayRecursiva(numeros, 0);

            print("La suma total es: " + total);   // Resultado: 25
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
