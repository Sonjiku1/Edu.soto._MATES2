using UnityEngine;

public class ExpectedValue : MonoBehaviour
{
    [Header("Numero de cartas")]
    [SerializeField] private int n_As = 4;
    [SerializeField] private int n_Tres = 4, n_Rey = 4, n_Caballo = 4, n_Sota = 4, n_Siete = 4, n_Seis = 4, n_Cinco = 4, n_Cuatro = 4, n_Dos = 4;

    [Header("Valores de cartas")]
    [SerializeField] private float v_As = 11;
    [SerializeField] private float v_Tres = 10, v_Rey = 4, v_Caballo = 3, v_Sota = 2, v_Siete = 0, v_Seis = 0, v_Cinco = 0, v_Cuatro = 0, v_Dos = 0;
}
