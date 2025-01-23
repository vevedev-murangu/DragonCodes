using UnityEngine;

public class ChaveAtivarObjeto : MonoBehaviour
{
    
    public GameObject chave;

    
    public GameObject objetoAtivado;

    
    public GameObject canvasAtivado;

    
    public GameObject jogador;

    
    public float distanciaLimite = 5f;

    
    void Update()
    {
        
        float distancia = Vector3.Distance(jogador.transform.position, transform.position);

        
        if (distancia <= distanciaLimite)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                
                chave.SetActive(false);

                
                objetoAtivado.SetActive(true);

                
                canvasAtivado.SetActive(true);

                
                Debug.Log("Tecla P pressionada e o jogador está a 5 ou menos de distância. Objetos ativados!");
            }
        }
        else
        {
            
            Debug.Log("Jogador está distante demais para ativar os objetos. Distância atual: " + distancia);
        }
    }
}
