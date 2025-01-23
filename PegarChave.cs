using UnityEngine;

public class PegarChave : MonoBehaviour
{
    public GameObject objetodereferencia;  
    public GameObject chavenamao;  
    public GameObject chavenochao;  
    public Canvas canvas;       

    public Transform player;    
    public float distanciaMinima = 5f;  

    private void Update()
    {
        
        float distancia = Vector3.Distance(player.position, objetodereferencia.transform.position);

        
        if (distancia <= distanciaMinima)
        {
            
            if (Input.GetKeyDown(KeyCode.P))
            {
               
                chavenochao.SetActive(false);

                
                chavenamao.SetActive(true);
                canvas.gameObject.SetActive(true);
            }
        }
    }
}
