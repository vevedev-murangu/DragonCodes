using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject targetObject; 
    public GameObject objectToDestroy; 

    private bool objectWasActive = false;

    void Update()
    {
        
        if (targetObject != null && targetObject.activeSelf && !objectWasActive)
        {
            objectWasActive = true;

            if (objectToDestroy != null)
            {
                Destroy(objectToDestroy); 
                Debug.Log($"{objectToDestroy.name} foi destruído!");
            }
        }
    }
}
