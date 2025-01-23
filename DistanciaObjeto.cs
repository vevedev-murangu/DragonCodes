using UnityEngine;

public class DistanciaObjeto : MonoBehaviour
{
    public GameObject objeto1;
    public GameObject objeto2; 
    public Canvas canvas; 
    public float distanciaAtivacao = 5f; 
    private void Update()
    {
        
        float distancia = Vector3.Distance(objeto1.transform.position, objeto2.transform.position);

        
        if (distancia <= distanciaAtivacao)
        {
           
            if (!canvas.gameObject.activeSelf)
            {
                canvas.gameObject.SetActive(true);
            }
        }
        else
        {
            
            if (canvas.gameObject.activeSelf)
            {
                canvas.gameObject.SetActive(false);
            }
        }
    }
}
