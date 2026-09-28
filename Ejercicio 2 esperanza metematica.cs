using UnityEngine;

public class Ejercicio2esperanzametematica : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
    
    }
    // Un método que reciba un float (de 0.0 a 1.0, si no, no hará nada) y devuelva el equivalente en % de probabilidad.
    public float ConvertirAPorcentaje(float valor)
    {
        // 1. Validamos que el valor esté entre 0.0 y 1.0
        if (valor < 0f || valor > 1f)
        {
            // Si está fuera de rango, no hacemos nada (devolvemos 0)
            return 0f;
        }

        //  Convertimos el valor decimal a porcentaje
        // Multiplicamos por 100 (porque 1.0 = 100%)
        float porcentaje = valor * 100f;

        return porcentaje;
    }

    // Un método que reciba un % de probabilidad (de 0% a 100%, si no, no hará nada) y devuelva el equivalente en decimales (float)
    public float ConvertirADecimal(float porcentaje)
    {
        // 1. Validamos que el porcentaje esté entre 0 y 100
        if (porcentaje < 0f || porcentaje > 100f)
        {
            // Si está fuera de rango, no hacemos nada (devolvemos 0)
            return 0f;
        }

        // 2. Convertimos el porcentaje a decimal
        // Dividimos entre 100 (porque 100% = 1.0)
        float valorDecimal = porcentaje / 100f;

        return valorDecimal;
    }

    //Un método que calcule la probabilidad con la fórmula básica.
    //Recibirá número de resultados buscados entre número de resultados posibles.
    //Se devolverá en formato %.
    public string CalcularProbabilidad(int resultadosBuscados, int resultadosPosibles)
    {
        // Evitamos división por cero
        if (resultadosPosibles == 0)
        {
            Debug.LogError("El número de resultados posibles no puede ser 0.");
            return "0%";
        }

        // Fórmula básica de probabilidad: (casos favorables / casos posibles) * 100
        float probabilidad = ((float)resultadosBuscados / resultadosPosibles) * 100f;

        // Devolvemos el resultado en formato porcentaje con 2 decimales
        return probabilidad.ToString("F2") + "%";

    }

    // Un método que calcule la probabilidad que suceda un evento O de que suceda otro.
    // (Ej: probabilidad de sacar una figura O un As en la baraja: 12/52 + 4/52 = 16/52).

    public string CalcularProbabilidadEventoO(int casosFavorablesEvento1, int casosFavorablesEvento2, int casosPosibles)
    {
        // Evitamos división por cero
        if (casosPosibles == 0)
        {
            Debug.LogError("El número de casos posibles no puede ser 0.");
            return "0%";
        }
        // Fórmula de probabilidad para eventos O: (casos favorables evento 1 + casos favorables evento 2) / casos posibles * 100
        float probabilidad = ((float)(casosFavorablesEvento1 + casosFavorablesEvento2) / casosPosibles) * 100f;
        // Devolvemos el resultado en formato porcentaje con 2 decimales
        return probabilidad.ToString("F2") + "%";
    }

    // Un método que calcule la probabilidad que suceda un evento Y de que suceda otro.
    // (Ej: probabilidad de sacar un As Y de que sea diamante: 4/52 x 13/52 = 16/52).

    public string CalcularProbabilidadEventoY(int casosFavorablesEvento1, int casosFavorablesEvento2, int casosPosibles)
    {
        // Evitamos división por cero
        if (casosPosibles == 0)
        {
            Debug.LogError("El número de casos posibles no puede ser 0.");
            return "0%";
        }
        // Fórmula de probabilidad para eventos Y: (casos favorables evento 1 * casos favorables evento 2) / casos posibles * 100
        float probabilidad = ((float)(casosFavorablesEvento1 * casosFavorablesEvento2) / casosPosibles) * 100f;
        // Devolvemos el resultado en formato porcentaje con 2 decimales
        return probabilidad.ToString("F2") + "%";
    }

    //Un método que sea como un dado de seis lados (D6). Al llamar al método devolverá un número entre el 1 y el 6 inclusive.

    public int TirarDado()
    {
        // Usamos Random.Range para generar un número aleatorio entre 1 y 6 (inclusive)
        return Random.Range(1, 7); // El segundo parámetro es exclusivo, por eso usamos 7
    }

    //un método que se le pase por parámetro una cantidad de lados y devuelva un número entre el 1 y la cantidad de lados inclusive.

    public int TirarDadoConLados(int cantidadLados)
    {
        // Validamos que la cantidad de lados sea al menos 1
        if (cantidadLados < 1)
        {
            Debug.LogError("La cantidad de lados debe ser al menos 1.");
            return 0; // Devolvemos 0 para indicar un error
        }
        // Usamos Random.Range para generar un número aleatorio entre 1 y cantidadLados (inclusive)
        return Random.Range(1, cantidadLados + 1); // El segundo parámetro es exclusivo, por eso usamos cantidadLados + 1
    }


    void Update()
    {

    }
}







// Un método que reciba un % de probabilidad (de 0% a 100%, si no, no hará nada) y devuelva el equivalente en decimales (float)




// Update is called once per frame
