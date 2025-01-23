using UnityEngine;

public class BotaoMissoes : MonoBehaviour
{
    public GameObject missoesCanvas; 

    private bool missoesAtivo = false;

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            
            missoesAtivo = !missoesAtivo;
            missoesCanvas.SetActive(missoesAtivo);

            
            if (missoesAtivo)
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
