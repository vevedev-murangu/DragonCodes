using UnityEngine;
using UnityEngine.SceneManagement;

public class FaseDois : MonoBehaviour
{
    public GameObject player; 
    public GameObject objeto1; 
    public int numeroDaCena; 

    private void Update()
    {
        
        float distancia = Vector3.Distance(player.transform.position, objeto1.transform.position);

        
        if (distancia <= 5f && Input.GetKeyDown(KeyCode.P))
        {
            
            SceneManager.LoadScene(numeroDaCena);
        }
    }
}
