using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecionaTemaPergunta : MonoBehaviour
{

    public Text txtTemaEscolhido;
    public string[] nomeTema;
    private int idTema;  //esse id vai identifcar qual vai ser o tema s

    private MenuSound somBotao;

    public void Start()
    {
        somBotao = FindObjectOfType(typeof(MenuSound)) as MenuSound;
        idTema = 0;
        txtTemaEscolhido.text = nomeTema[idTema];

    }

    // Update is called once per frame
    public void Tema(int i)
    {

        somBotao.PlayBotao();
        idTema = i;
        txtTemaEscolhido.text = nomeTema[idTema];

    }

}
