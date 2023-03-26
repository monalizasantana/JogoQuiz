using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour
{
    // public AudioSource MenuSd;

    public AudioSource audioMusic, audioFix;
    public AudioClip somAcerto, somErro, somBotao, musicaEstrelas;
    public AudioClip[] musicas;

    /* public  void Start()
     {
       Carregarpreferencias();
       audioMusic.clip = musicas[0];
       audioMusic.Play();
     }*/

    public void Awake()  // essa função é propria do moneberepe - ao acordar
    {
        DontDestroyOnLoad(this.gameObject); //sgnifica n dest rua objeto ao carregar a cena 
    }

    public void PlayAcerto()
    {
        audioFix.volume = 1;
        audioFix.PlayOneShot(somAcerto);// ele vai tocar uma vez sem interferir no audio anteriro 
    }

    public void PlayErro()
    {
        audioFix.volume = 1;
        audioMusic.PlayOneShot(somErro);
    }

    public void PlayBotao()
    {
        audioFix.volume = 1;
        audioFix.PlayOneShot(somBotao);

    }
    public void PlayMusicaEstrelas()
    {
        audioFix.clip = musicaEstrelas;
        audioFix.Play();
    }
    public void Carregarpreferencias()
    {
        //verifica se há registro dos valores iniciais de configurações, se não houver, grava os valores iniciais

        if (PlayerPrefs.GetInt("valoresDefault") == 0)
        {
            PlayerPrefs.SetInt("valoresDefault", 1);
            PlayerPrefs.SetInt("offMusica", 1);
            // PlayerPrefs.SetInt("offEfeitos", 1);
            PlayerPrefs.SetFloat("volumeMusica", 1);
            // PlayerPrefs.SetFloat("volumeEfeitos", 1);

        }
        //CARREGA OS VALORES DE CONFIGURAÇÕES DOS SONS E MUSICAS 
        int offMusica = PlayerPrefs.GetInt("offMusica");
        // int offEfeitos = PlayerPrefs.GetInt("offEfeitos");
        float volumeMusica = PlayerPrefs.GetFloat("volumeMusica");
        // float volumeEfeitos = PlayerPrefs.GetFloat("volumeEfeitos");


        bool tocarMusica = false;
        // bool tocarEfeitos = false;


        if (offMusica == 1) { tocarMusica = true; }
        // if(offEfeitos == 1){ tocarEfeitos = true; }

        audioMusic.mute = !tocarMusica;
        // audioFix.mute = !tocarEfeitos;

        audioMusic.volume = volumeMusica;
        //audioFix.volume = volumeEfeitos;

    }


}
