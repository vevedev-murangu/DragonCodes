using UnityEngine;

public class ConcluidoOnDestroy : MonoBehaviour
{
    public GameObject concluidoicon; 
    public GameObject pergaminho; 

    private bool concluidoiconAtivo = false;

    void Update()
    {
        
        if (concluidoicon.activeSelf && !concluidoiconAtivo)
        {
            concluidoiconAtivo = true; 
            Destroy(objeto2); 
        }
    }
}
