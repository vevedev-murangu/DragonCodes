using UnityEngine;

public class AtivarCanvasaoIniciar : MonoBehaviour
{
    public GameObject canvas;
    private float timer = 0f; 
    public float duration = 5f; 

    void Start()
    {
        
        canvas.SetActive(true);
    }

    void Update()
    {
        
        timer += Time.deltaTime;

        
        if (timer >= duration)
        {
            canvas.SetActive(false);
            
            enabled = false;
        }
    }
}
