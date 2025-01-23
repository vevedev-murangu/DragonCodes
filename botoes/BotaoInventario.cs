using UnityEngine;

public class BotaoInventario : MonoBehaviour
{
    public GameObject inventarioCanvas; 

    private bool inventarioAtivo = false;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            inventarioAtivo = !inventarioAtivo;
            inventarioCanvas.SetActive(inventarioAtivo);

            
            if (inventarioAtivo)
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
