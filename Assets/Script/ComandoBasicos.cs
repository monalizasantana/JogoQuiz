using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComandoBasicos : MonoBehaviour
{
    private MenuSound somBotao;


    public void Start()
    {
        somBotao = FindObjectOfType(typeof(MenuSound)) as MenuSound;
    }
    public void CarregarCena(string nomeCena)
    {
        somBotao.PlayBotao();

        if (SceneManager.GetActiveScene().name != "telaInicial" && SceneManager.GetActiveScene().name != "temas")
        {
            somBotao.audioMusic.clip = somBotao.musicas[0];
            somBotao.audioMusic.Play();
        }
        SceneManager.LoadScene(nomeCena);
        //Application.LoadLevel(nomeCena);
    }


    /*public void voltarTelaInicial()
    {
        somBotao.AudioMusic.clip = somBotao.musicas[0];
        somBotao.AudioMusic.Play();
        SceneManager.LoadScene("telaInicial");
    }*/

    /* public void irTema()
    {
        
       somBotao.AudioMusic.clip = somBotao.musicas[0];
       somBotao.AudioMusic.Play();
       SceneManager.LoadScene("temas");
     }*/



    public void Sair()//FECHAR O APLICATIVO SO FUNCIONAR PARA MOBILE 
    {
        somBotao.PlayBotao();
        Application.Quit();
    }

}