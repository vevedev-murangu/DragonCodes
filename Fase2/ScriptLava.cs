using UnityEngine;
using UnityEngine.UI;

public class ScriptLava : MonoBehaviour
{
    public GameObject player; 
    public GameObject lava; 
    public GameObject chao; 
    public GameObject deathScreen; 
    public Image cronometro; 
    public float distanciaAtivacao = 3f;
    public float distanciaDesativacao = 3f; 
    public float tempoInicial = 5f; 

    private bool cronometroAtivo = false;
    private float tempoAtual;

    void Start()
    {
        cronometro.gameObject.SetActive(false); 
        tempoAtual = tempoInicial;
        deathScreen.SetActive(false); 
    }

    void Update()
    {
        float distanciaLava = Vector3.Distance(player.transform.position, lava.transform.position);
        float distanciaChao = Vector3.Distance(player.transform.position, chao.transform.position);

        
        if (distanciaLava <= distanciaAtivacao && !cronometroAtivo)
        {
            AtivarCronometro();
        }

        
        if (cronometroAtivo && distanciaChao <= distanciaDesativacao)
        {
            DesativarCronometro();
        }

        
        if (cronometroAtivo)
        {
            AtualizarCronometro();
        }
    }

    void AtivarCronometro()
    {
        cronometroAtivo = true;
        cronometro.gameObject.SetActive(true);
        tempoAtual = tempoInicial; 
    }

    void AtualizarCronometro()
    {
        tempoAtual -= Time.deltaTime;
        cronometro.fillAmount = tempoAtual / tempoInicial;

        if (tempoAtual <= 0)
        {
            AtivarTelaDeMorte();
        }
    }

    void DesativarCronometro()
    {
        cronometroAtivo = false;
        cronometro.gameObject.SetActive(false);
        tempoAtual = tempoInicial; 
    }

    void AtivarTelaDeMorte()
    {
        deathScreen.SetActive(true); 
        Time.timeScale = 0; 
    }
}
