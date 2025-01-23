using UnityEngine;

public class SnakeFollow : MonoBehaviour
{
    public Transform player; 
    public float followDistance = 5f; 
    public float stopDistance = 2f; 
    public float speed = 2f; 
    public GameObject telaDeMorte; 
    private Animator animator; 
    private float initialY; 
    private Vector3 lastValidPosition; 

    void Start()
    {
        
        Time.timeScale = 1;

        animator = GetComponent<Animator>(); 
        initialY = transform.position.y; 
        lastValidPosition = transform.position;

        if (telaDeMorte != null)
        {
            telaDeMorte.SetActive(false); 
        }
    }

    void Update()
    {
        if (player == null) return; 

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= stopDistance)
        {
            PauseGame();
        }
        else if (distanceToPlayer <= followDistance)
        {
            FollowPlayer();
        }
        else
        {
            StopFollowing();
        }
    }

    void FollowPlayer()
    {
        
        if (animator != null)
        {
            animator.Play("SnakeAndando");
        }

        
        Vector3 direction = (player.position - transform.position).normalized;

       
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);

       
        Vector3 movePosition = transform.position + direction * speed * Time.deltaTime;
        movePosition.y = initialY; 

        
        if (IsPositionValid(movePosition))
        {
            transform.position = movePosition;
            lastValidPosition = transform.position; 
        }
        else
        {
            
            transform.position = lastValidPosition;
        }
    }

    void StopFollowing()
    {
       
        if (animator != null)
        {
            animator.Play("SnakeParado");
        }
    }

    void PauseGame()
    {
        
        Time.timeScale = 0;
        if (telaDeMorte != null)
        {
            telaDeMorte.SetActive(true);
        }
    }

    bool IsPositionValid(Vector3 newPosition)
    {
        
        Collider[] colliders = Physics.OverlapBox(newPosition, GetComponent<Collider>().bounds.extents, Quaternion.identity);

        foreach (Collider collider in colliders)
        {
            if (collider.gameObject != gameObject) 
            {
                return false; 
            }
        }

        return true; 
    }
}
