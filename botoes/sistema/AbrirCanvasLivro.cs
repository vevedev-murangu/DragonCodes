using UnityEngine;

public class AbrirCanvasLivro : MonoBehaviour
{
    public GameObject player; 
    public GameObject livroTeste; 
    public Canvas canvas; 
    public float distanciaRequerida = 5f; 

    private bool canvasAtivo = false; 

    void Start()
    {
        
        if (canvas != null)
        {
            canvas.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (livroTeste == null || player == null || canvas == null) return;

        
        float distancia = Vector3.Distance(player.transform.position, livroTeste.transform.position);

        
        if (distancia <= distanciaRequerida && Input.GetKeyDown(KeyCode.P))
        {
            
            canvasAtivo = !canvasAtivo;
            canvas.gameObject.SetActive(canvasAtivo);
        }
    }
}
