using UnityEngine;

public class MoverLadoaLado : MonoBehaviour
{
    public float velocidade = 5f; 
    public float distanciaMaxima = 5f; 
    private Vector3 posicaoInicial; 

    void Start()
    {
        posicaoInicial = transform.position; 
    }

    void Update()
    {
        
        float deslocamento = Mathf.Sin(Time.time * velocidade) * distanciaMaxima;

        
        transform.position = posicaoInicial + new Vector3(deslocamento, 0, 0);
    }
}
