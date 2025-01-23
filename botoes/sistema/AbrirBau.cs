using UnityEngine;

public class AbrirBau : MonoBehaviour
{
    public Animator animatorBau; 
    public GameObject canvasbauaberto;    

    private bool animacaoIniciada = false;

    void Start()
    {
        
        if (canvas != null)
        {
            canvasbauaberto.SetActive(false);
        }
    }

    void Update()
    {
        
        if (animatorBau != null && animatorBau.GetCurrentAnimatorStateInfo(0).IsName("AbrindoBau") && !animacaoIniciada)
        {
            animacaoIniciada = true; 
            if (canvasbauaberto != null)
            {
                canvasbauaberto.SetActive(true); 
            }
        }
    }
}
