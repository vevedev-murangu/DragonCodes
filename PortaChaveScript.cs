using UnityEngine;

public class PortaChaveScript : MonoBehaviour
{
    public GameObject chave;
    public Animator portaAnimator;
    public Transform objeto1;
    public Transform objeto2;
    public float distanciaMinima = 5f;
    public GameObject canvasTemporario;
    public AudioSource audioSource; 

    private bool jaAtivado = false;

    private void Update()
    {
        
        if (Vector3.Distance(objeto1.position, objeto2.position) <= distanciaMinima)
        {
            
            if (Input.GetKeyDown(KeyCode.O) && !jaAtivado)
            {
                jaAtivado = true;

                
                portaAnimator.SetTrigger("Abrir");

                
                if (audioSource != null)
                {
                    audioSource.Play(); 
                }

                
                Destroy(chave);

                
                canvasTemporario.SetActive(true);
            }
        }

        
        if (Input.GetKeyDown(KeyCode.W))
        {
            canvasTemporario.SetActive(false);
        }
    }
}
