using UnityEngine;

public class SnakePause : MonoBehaviour
{
    public GameObject canvasFlauta; 
    private SnakeFollow snakeFollow; 
    private Animator animator; 

    void Start()
    {
        
        snakeFollow = GetComponent<SnakeFollow>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (canvasFlauta != null && canvasFlauta.activeSelf)
        {
           
            if (snakeFollow != null) snakeFollow.enabled = false;
            if (animator != null) animator.Play("SnakeParado");
        }
        else
        {
            
            if (snakeFollow != null) snakeFollow.enabled = true;
        }
    }
}
