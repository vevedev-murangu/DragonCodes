using UnityEngine;

public class Esc : MonoBehaviour
{
    public GameObject canvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            canvas.SetActive(!canvas.activeSelf);

            
            if (canvas.activeSelf)
            {
                Time.timeScale = 0f; 
            }
            else
            {
                Time.timeScale = 1f; 
            }
        }
    }
}
