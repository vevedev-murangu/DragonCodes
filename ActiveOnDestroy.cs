using UnityEngine;
using UnityEngine.UI; 

public class ActiveOnDestroy : MonoBehaviour
{
    public GameObject keyObject;  
    public GameObject object1;   
    public GameObject object2;   
    public GameObject object3;    

    void Update()
    {
        
        if (keyObject != null && keyObject.activeSelf)
        {
            object2.SetActive(true);
        }

        
        if (keyObject == null)
        {
            ActivateObjects();
        }
    }

    void ActivateObjects()
    {
        
        if (object1 != null)
        {
            object1.SetActive(true);
        }

        
        if (object3 != null)
        {
            object3.SetActive(false);
        }

        
        enabled = false;
    }
}
