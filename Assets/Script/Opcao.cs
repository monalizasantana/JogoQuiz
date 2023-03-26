using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Opcao : MonoBehaviour
{

    private MenuSound somBotao;
    public GameObject panel1, panel2;
    public Toggle offMusica, offEfeitos;
    public Slider volumeM, volumeE;


    public void Start()
    {
        somBotao = FindObjectOfType(typeof(MenuSound)) as MenuSound;
        Carregarpreferencias();
        panel1.SetActive(true);
        panel2.SetActive(false);
    }
    public void Configuracao(bool desligarBotao) //criar um painel 
    {
        somBotao.PlayBotao();
        panel1.SetActive(!desligarBotao);
        panel2.SetActive(desligarBotao);

    }

    public void ResetarPontuacoes()
    {
        somBotao.PlayBotao();
        PlayerPrefs.DeleteAll();
    }

    public void MutarMusica()
    {

        somBotao.audioMusic.mute = !offMusica.isOn; //desliga o som
        if (offMusica.isOn == true)
        {
            PlayerPrefs.SetInt("offMusica", 1);
        }
        else
        {
            PlayerPrefs.SetInt("offMusica", 0);
        }
    }
    /* if(offMusica.isOn == false)
    {
        somBotao.AudioMusic.mute = true;
    }
    else
    {
        somBotao.AudioMusic.mute = false;

    }*/



    /* public void MutarEfeito()
     {
         somBotao.audioFix.mute = !offEfeitos.isOn;
         if(offEfeitos.isOn == true)
         {
             PlayerPrefs.SetInt("offEfeito", 1); // gravar a mudança do efeito
         }
         else
         {
             PlayerPrefs.SetInt("offEfeito", 0);
         }
     }*/
    public void VolumeMusica()
    {
        somBotao.audioMusic.volume = volumeM.value;
        PlayerPrefs.SetFloat("volumeMusica", volumeM.value);
    }

    /* public void volumeEfeitos()
     {
         somBotao.audioFix.volume = volumeE.value;
         PlayerPrefs.SetFloat("volumeEfeito", volumeE.value);
     }*/

    public void Carregarpreferencias()
    {
        //CARREGA OS VALORES DE CONFIGURAÇÕES DOS SONS E MUSICAS 
        int offM = PlayerPrefs.GetInt("offMusica");
        //int offE = PlayerPrefs.GetInt("offEfeitos");
        float volumeMusica = PlayerPrefs.GetFloat("volumeMusica");
        //float volumeEfeitos = PlayerPrefs.GetFloat("volumeEfeitos");

        bool tocarMusica = false;
        //   bool tocarEfeitos = false;


        if (offM == 1) { tocarMusica = true; }
        // if (offE == 1) { tocarEfeitos = true; }

        offMusica.isOn = tocarMusica;
        //offEfeitos.isOn = tocarEfeitos;

        volumeM.value = volumeMusica;
        // volumeE.value = volumeEfeitos;

    }

}






