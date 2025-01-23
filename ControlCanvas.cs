using UnityEngine;

public class ControlCanvas : MonoBehaviour
{
    public GameObject object1; 
    public GameObject object2; 

    void Update()
    {
       
        if (object1.activeSelf)
        {
            
            object2.SetActive(false);
        }
        else
        {
            
            object2.SetActive(true);
        }
    }
}
