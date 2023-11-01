using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public Text textoPontuacao;
    public PlayerControll player;
    public LevaNaveAoPlaneta levaNaveAoPlaneta;
    Vector3 posicaoInicial;
    public float divisorDaPontuacao;
    public GameObject painelGameOver;
    public GameObject painelVenceuJogo;
    public AudioClip sfxVenceuJogo;
    public AudioController audioController;
    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null) 
        {
            return;
        }
        Vector3 distanciaPercorrida = player.transform.position - posicaoInicial;
        float pontuacao = distanciaPercorrida.z / divisorDaPontuacao;
        textoPontuacao.text = pontuacao.ToString("0");
    }

    public void GameOver()
    {
        painelGameOver.SetActive(true); 
    }

    public void VencerJogo() 
    {
        levaNaveAoPlaneta.LeveNaveAoPlaneta();
        audioController.ToqueSFX(sfxVenceuJogo);
        painelVenceuJogo.SetActive(true);
    }

    public void RecarregarLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SairdoJogo() 
    {
        Application.Quit();
    }
}
