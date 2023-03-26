using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Responder : MonoBehaviour
{


    private int idTema;
    [Header("Configuração dos Textos ")]
    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    // public Text respostaD;
    public Text infoResposta;

    [Header("Configuração das Perguntas")]
    public bool utilizarAlternativas;
    public string[] perguntas;       // armazena todas as perguntas;
    public string[] alternativaA;   // armazena todas as alternativas A;
    public string[] alternativaB;
    public string[] alternativaC;
    //public string[] alternativaD;

    [Header(" Configurações dos Botões")]
    public Button[] botoes;
    public Color corAcerto, corErro;
    public Button buttonProximo;

    public string[] AlternativasCorretas;




    [Header("Configuração do Modo de Jogo")]
    public bool mostrarRespostaCerta;
    public int qtdVezesPiscar;

    public string[] corretas;              // armazena todas as alternativas corretas;
    //------------------------------
    private int idResponder;
    private int idPergunta;      // id das perguntas;

    private float acertos, questoes, media;
    private int notaFinal, idBtnCorreto;
    private bool exibindoCorreta;
    private MenuSound somBotao;

    private MenuSound menuSound;
    public void Start()
    {

        menuSound = FindObjectOfType(typeof(MenuSound)) as MenuSound;

        idTema = PlayerPrefs.GetInt("idTema");

        idPergunta = 0;
        questoes = perguntas.Length;

        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        // respostaD.text = alternativaD[idPergunta];

        infoResposta.text = "Respondendo" + (idPergunta + 1) + " de " + questoes.ToString() + " perguntas.";
        buttonProximo.interactable = false;
    }

    // ESTÁ FUNÇÃO É RESPONSAVEL POR PROCESSAR A RESPOSTA DADA PELO JOGADOR
    public void Resposta(string alternativa)
    {
        //VERIFICAR SE NO MODO DE JOGO ESTÁ SETADO PARA EXIBIR AS ALTERNATIVAS CORRETA, CASO ESTEJA, ELE RETORNA EM CASO DE MAIS DE UM CLIQUE
        if (exibindoCorreta == true)
        {
            return;
        }

        if (alternativa == "A")
        {
            //VERIFICA SE A RESPOSTA ESTA CORRETA E INCREMTA UM NA QUATIDADE DE ACERTS 
            if (alternativaA[idPergunta] == corretas[idPergunta])
            {
                acertos++;
                menuSound.PlayAcerto();
            }
            else
            {
                menuSound.PlayErro();
            }

        }
        else if (alternativa == "B")
        {
            if (alternativaB[idPergunta] == corretas[idPergunta])
            {
                acertos++;
                menuSound.PlayAcerto();
            }
            else
            {
                menuSound.PlayErro();
            }

        }
        else if (alternativa == "C")
        {

            if (alternativaC[idPergunta] == corretas[idPergunta])
            {
                acertos++;
                menuSound.PlayAcerto();
            }
            else
            {
                menuSound.PlayErro();
            }
        }
        /* else if (alternativa == "D")
         {
             if (alternativaD[idPergunta] == corretas[idPergunta])
             {
                 acertos++;
                 menuSound.PlayAcerto();
             }
             else
             {
                 menuSound.PlayErro();
             }


         }*/
        // INDICA QUAL BOTÃO CONTÉM A RESPOSTA CORRETA  
        switch (AlternativasCorretas[idPergunta])
        {
            case "A":
                idBtnCorreto = 0;
                break;
            case "B":
                idBtnCorreto = 1;
                break;
            case "C":
                idBtnCorreto = 2;
                break;

        }

        buttonProximo.interactable = true;

        // EXIBINDO CORRETA, ALTERA A COR DOS BOTOES E FAZ A CHAMA DA FUNÇÃO DE ANIMAÇAO
        if (mostrarRespostaCerta == true)
        {
            foreach (Button b in botoes)
            {
                b.image.color = corErro;
            }
            exibindoCorreta = true;
            botoes[idBtnCorreto].image.color = corAcerto;
            StartCoroutine("MostrarAlternativaCorreta");
            // buttonProximo.interactable = true;

        }
        else // CASO O MODO DE JOGO NÃO ESTEJA PARA EXIBIR A CORRETA, CHAMA A PRÓXIMA PERGUNTA
        {

            StartCoroutine("aguradar aproxima");
        }


    }


    [System.Obsolete]
    //FUNÇÃO RESPONSÁVEL POR PROCESSAR AS PERGUNTAS, FAZ A CHAMADA DE UMA NOVA OU ENCERRA O TESTE
    public void ProximaPergunta()
    {
        if (buttonProximo.interactable == true)
        {
            buttonProximo.interactable = false;
        }
        else
        {
            buttonProximo.interactable = true;

        }

        idPergunta++;

        EventSystem.current.SetSelectedGameObject(null);

        if (idPergunta <= (questoes - 1))
        {
            pergunta.text = perguntas[idPergunta];

            respostaA.text = alternativaA[idPergunta];
            respostaB.text = alternativaB[idPergunta];
            respostaC.text = alternativaC[idPergunta];
            //respostaD.text = alternativaD[idPergunta];
            infoResposta.text = "Respondendo " + (idPergunta + 1) + " de " + questoes.ToString() + " perguntas.";

        }
        else // FAZ OS CALCULOS DA NOTA FINAL
        {

            media = 10 * (acertos / questoes); // calcula a media com base no pecentual  de acertos
            notaFinal = Mathf.RoundToInt(media); //arredonda a nota para o proximo inteiro, seguindo a regra da matematica.

            if (notaFinal > PlayerPrefs.GetInt("notaFinal" + idTema.ToString()))
            {
                PlayerPrefs.SetInt("notaFinal" + idTema.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idTema.ToString(), (int)acertos);
            }
            PlayerPrefs.SetInt("notaFinalTemp" + idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idTema.ToString(), (int)acertos);

            Application.LoadLevel("notaFinal");
            //SceneManager.LoadScene("notaFinal");

        }
    }

    [System.Obsolete]
    public IEnumerator aguardarProxima()
    {
        yield return new WaitForSeconds(1);
        exibindoCorreta = false;
        ProximaPergunta();
    }

    public IEnumerator MostrarAlternativaCorreta()
    {
        for (int i = 0; i < qtdVezesPiscar; i++)
        {
            botoes[idBtnCorreto].image.color = corAcerto;
            yield return new WaitForSeconds(0.2f);
            botoes[idBtnCorreto].image.color = Color.white;
            yield return new WaitForSeconds(0.2f);

        }
        foreach (Button b in botoes)
        {
            b.image.color = Color.white;
        }

        // ProximaPergunta();
    }

    [System.Obsolete]
    public void BtnConfirmarPergunta()
    {
        exibindoCorreta = false;
        ProximaPergunta();


    }
}
