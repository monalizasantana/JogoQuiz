using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TemaJogo : MonoBehaviour
{

    public Button buttonPlay;
    public Text txtNomeTema;
    public GameObject infoTema;
    public Text txtInfoTema;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    public Color[] color;
    public string[] nomeTema;
    private int idTema;  //esse id vai identifcar qual vai ser o tema s
    public int numeroQuestoes;

    private int notaFinal = 0;
    private int acertos = 0;
    private MenuSound somBotao;


    public void Start()
    {
        somBotao = FindObjectOfType(typeof(MenuSound)) as MenuSound;

        idTema = 0;
        txtNomeTema.text = nomeTema[idTema];
        txtInfoTema.text = "";
        infoTema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        buttonPlay.interactable = false;
    }

    public void SelecioneTema(int i)
    {
        somBotao.PlayBotao();

        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);
        txtNomeTema.text = nomeTema[idTema];
        txtNomeTema.color = Color.black;


        notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());

        estrela1.SetActive(true);
        estrela2.SetActive(true);
        estrela3.SetActive(true);

        if (notaFinal == 10)
        {

            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }

        else if (notaFinal >= 70)
        {

            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }

        else if (notaFinal >= 50)
        {

            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }


        txtInfoTema.text = "Voce acertou  " + acertos.ToString() + " de " + numeroQuestoes.ToString() + " questoes";
        infoTema.SetActive(true);
        buttonPlay.interactable = true;
    }
    public void Jogar()
    {

        somBotao.PlayBotao();

        somBotao.audioMusic.clip = somBotao.musicas[1];
        somBotao.audioMusic.Play();
        //Application.LoadLevel("tema" + idTema.ToString());
        SceneManager.LoadScene("tema" + idTema.ToString());
    }

}
