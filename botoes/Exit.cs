using UnityEngine;

public class MenuQ : MonoBehaviour
{
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            Application.Quit();

            
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}
