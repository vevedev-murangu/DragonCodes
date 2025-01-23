using System.Collections;
using UnityEngine;

public class FlautaControlador : MonoBehaviour
{
    public GameObject flauta; 
    public Canvas canvas; 
    public GameObject objeto3; 
    public float tempoAtivacao = 3f; 
    public float tempoEspera = 5f; 

    private bool podeAtivar = true; 
    private bool flautaAtivada = false; 

    void Start()
    {
        
        objeto3.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && podeAtivar)
        {
            if (flautaAtivada)
            {
                DesativarFlauta();
            }
            else
            {
                AtivarFlauta();
            }
        }
    }

    void AtivarFlauta()
    {
       
        flauta.SetActive(true);
        canvas.gameObject.SetActive(true);
        flautaAtivada = true;

        
        StartCoroutine(DesativarFlautaDepoisDeTempo(tempoAtivacao));

       
        objeto3.SetActive(false);
    }

    void DesativarFlauta()
    {
        
        flauta.SetActive(false);
        canvas.gameObject.SetActive(false);
        flautaAtivada = false;

        
        StartCoroutine(AguardarAntesDeAtivar(tempoEspera));

       
        objeto3.SetActive(false);
    }

    IEnumerator DesativarFlautaDepoisDeTempo(float tempo)
    {
        yield return new WaitForSeconds(tempo);
        DesativarFlauta();
    }

    IEnumerator AguardarAntesDeAtivar(float tempo)
    {
        podeAtivar = false;
        yield return new WaitForSeconds(tempo);
        podeAtivar = true;

        

        objeto3.SetActive(true);
    }
}
