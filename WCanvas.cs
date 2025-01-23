using UnityEngine;

public class WCanvas : MonoBehaviour
{
    public Canvas canvas; 

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
           
            if (canvas != null)
            {
                canvas.gameObject.SetActive(false);
            }
        }
    }
}
