using UnityEngine;

public class ZaratiScript : MonoBehaviour
{
    public GameObject player; 
    public GameObject livroDeZarati; 
    public GameObject objeto1; 
    public GameObject objeto2; 
    public GameObject objeto3; 
    public Canvas canvas2; 
    public float distanciaRequerida = 5f; 

    void Start()
    {
       
        if (objeto1 != null) objeto1.SetActive(false);
        if (objeto2 != null) objeto2.SetActive(false);
        if (objeto3 != null) objeto3.SetActive(false);
        if (canvas2 != null) canvas2.gameObject.SetActive(false);
    }

    void Update()
    {
        if (livroDeZarati == null || player == null) return;

        
        float distancia = Vector3.Distance(player.transform.position, livroDeZarati.transform.position);

        
        if (distancia <= distanciaRequerida && Input.GetKeyDown(KeyCode.O))
        {
            
            Destroy(livroDeZarati);

            
            if (objeto1 != null) objeto1.SetActive(true);
            if (objeto2 != null) objeto2.SetActive(true);
            if (objeto3 != null) objeto3.SetActive(true);
            if (canvas2 != null) canvas2.gameObject.SetActive(true);
        }
    }
}
