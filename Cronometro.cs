using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public Image cronometroImage;
    public float tempoTotal = 10f; 
    private float tempoDecorrido = 0f;
    private bool cronometroAtivo = false;

    void OnEnable()
    {
        
        IniciarCronometro();
    }

    void Update()
    {
        if (cronometroImage != null && cronometroAtivo)
        {
            
            tempoDecorrido += Time.deltaTime;

            
            if (tempoDecorrido <= tempoTotal)
            {
                
                cronometroImage.fillAmount = Mathf.Lerp(1f, 0f, tempoDecorrido / tempoTotal);
            }
            else
            {
               
                cronometroImage.fillAmount = 0f;
                cronometroAtivo = false; 
            }
        }
    }

    
    public void IniciarCronometro()
    {
        tempoDecorrido = 0f; 
        cronometroImage.fillAmount = 1f; 
        cronometroAtivo = true;
    }

    
    public void ReiniciarCronometro()
    {
        tempoDecorrido = 0f;
        cronometroImage.fillAmount = 1f; 
        cronometroAtivo = true; 
    }
}
