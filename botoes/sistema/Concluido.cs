using UnityEngine;

public class Concluido : MonoBehaviour
{
    
    public GameObject objeto1;
    public GameObject objeto2;

    void Update()
    {
        
        if (objeto1.activeSelf && !objeto2.activeSelf)
        {
            
            objeto2.SetActive(true);
        }
    }
}
