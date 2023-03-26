using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NotaFinal : MonoBehaviour
{
    private MenuSound somBotao;

    private int idTema;

    public Text txtNota;
    public Text txtInfoTema;
    public Text msg1Txt;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    private int notaFinal;
    private int acertos;

    public string[] mensagem1;
    public Color[] corMensagens;


    //[Header("Configuração dos Textos")]
    private int notaMin2estrela, notaMin1Estrela, nEstrelas;

    public void Start()
    {
        somBotao = FindObjectOfType(typeof(MenuSound)) as MenuSound;

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);




        idTema = PlayerPrefs.GetInt("idTema");
        notaFinal = PlayerPrefs.GetInt("notaFinalTemp" + idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp" + idTema.ToString());


        txtNota.text = notaFinal.ToString();
        txtInfoTema.text = "Você acertou  " + acertos.ToString() + " de 5 perguntas";

        notaMin1Estrela = 5;
        notaMin2estrela = 7;

        if (notaFinal == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
            { nEstrelas = 3; }
            // MenuSound.PlayMusicaEstrelas();
        }
        else if (notaFinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
            { nEstrelas = 2; }
        }
        else if (notaFinal >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);

            { nEstrelas = 1; }
        }
        msg1Txt.text = mensagem1[nEstrelas];
        txtNota.color = corMensagens[nEstrelas];
        msg1Txt.color = corMensagens[nEstrelas];


    }


    public void JogarNovamente()

    {
        somBotao.PlayBotao();
        SceneManager.LoadScene("tema" + idTema.ToString());
        // Application.LoadLevel("tema" + idTema.ToString());
    }

}






