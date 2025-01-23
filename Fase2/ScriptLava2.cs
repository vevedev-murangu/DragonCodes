using UnityEngine;

public class ScriptLava2 : MonoBehaviour
{
    public GameObject player; 
    public GameObject cubo; 
    public GameObject deathScreen; 
    public float distanciaAtivacao = 2f; 

    void Start()
    {
        deathScreen.SetActive(false); 
    }

    void Update()
    {
        
        float distancia = Vector3.Distance(player.transform.position, cubo.transform.position);

        
        Debug.Log("Distância entre o jogador e o cubo: " + distancia);

        
        if (distancia <= distanciaAtivacao)
        {
            AtivarTelaDeMorte();
        }
    }

    void AtivarTelaDeMorte()
    {
        deathScreen.SetActive(true); 
        
    }
}
