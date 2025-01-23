using UnityEngine;

public class Papel : MonoBehaviour
{
    public GameObject player;      
    public GameObject papel;       
    public GameObject objeto1;     
    public GameObject objeto2;     
    public float distanciaMaxima = 5f; 

    private float tempoAtivacao = 5f; 
    private float timer = 0f;         
    private bool objeto1Ativo = false;

    void Start()
    {
        
        if (objeto1 != null) objeto1.SetActive(false);
        if (objeto2 != null) objeto2.SetActive(false);
    }

    void Update()
    {
        
        if (player == null)
        {
            Debug.LogError("Player não atribuído no Inspector!");
            return;
        }

        
        if (Vector3.Distance(player.transform.position, papel.transform.position) <= distanciaMaxima)
        {
            
            if (Input.GetKeyDown(KeyCode.P))
            {
                AtivarObjetos();
            }
        }

        
        if (objeto1Ativo)
        {
            timer += Time.deltaTime;
            if (timer >= tempoAtivacao)
            {
                DesativarObjeto1();
            }
        }
    }

    void AtivarObjetos()
    {
        if (objeto1 != null)
        {
            objeto1.SetActive(true); 
            objeto1Ativo = true;
            timer = 0f; 
        }

        if (objeto2 != null)
        {
            objeto2.SetActive(true); 
        }
    }

    void DesativarObjeto1()
    {
        if (objeto1 != null)
        {
            objeto1.SetActive(false); 
            objeto1Ativo = false;
        }
    }
}
