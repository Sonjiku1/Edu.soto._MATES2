using System;
using System.Collections;
using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public static ArrayList GenerarFibonacci(int cantidad)
    {
        ArrayList fib = new ArrayList();

        if (cantidad <= 0)
            return fib;

        fib.Add(0L);

        if (cantidad == 1)
            return fib;

        fib.Add(1L);

        for (int i = 2; i < cantidad; i++)
        {
            long anterior1 = (long)fib[i - 1];
            long anterior2 = (long)fib[i - 2];
            fib.Add(anterior1 + anterior2);
        }

        return fib;
    }

    static void Main()
    {
        ArrayList secuencia = GenerarFibonacci(15);

        Console.WriteLine("Secuencia de Fibonacci:");

        // Mostrar los números con un for normal (sin foreach)
        for (int i = 0; i < secuencia.Count; i++)
        {
            Console.Write(secuencia[i] + " ");
        }


        // Contar las cifras de un numero entero n (no negativo) y mostrar el coste temporal de la operación y coste espacial de la operación

         int numero = 1234567890; // Ejemplo de número entero no negativo

        // mostrar el coste temporal 
        // el coste temporal de contar las cifras de un número entero n es O(log10(n)), ya que el número de dígitos en un número n es proporcional al logaritmo base 10 de n. sin hacer math floor

        int log10 = (int)Math.Log10(numero) + 1; // +1 para contar el dígito más significativo



        //Mostrar el coste espacial
        // el coste espacial de contar las cifras de un número entero n es O(1), ya que solo se necesita un espacio constante para almacenar el contador de dígitos, independientemente del tamaño del número.

        int costeEspacial = 1; // Espacio constante

        Debug.Log($"Número: {numero}, Cifras: {log10}, Coste temporal: O(log10(n)), Coste espacial: O(1)");

        // Mostrar el mejor y peor caso de la operación de contar cifras de un número entero n (no negativo) sin math pow

        int mejorCaso = 1; // El mejor caso es cuando n es un solo dígito (0-9)
        
       int peorCaso = log10*1000; // El peor caso es cuando n tiene muchos dígitos, por ejemplo, un número grande como 9999999999 (10 dígitos)
        Debug.Log($"Mejor caso: {mejorCaso} dígito(s), Peor caso: {peorCaso} dígito(s)");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
