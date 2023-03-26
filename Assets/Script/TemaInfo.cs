﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TemaInfo : MonoBehaviour
{
    public int idTema;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    private MenuSound somBotao;

    private int notaFinal;

    public void Start()
    {
        somBotao = FindObjectOfType(typeof(MenuSound)) as MenuSound;

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());

        if (notaFinal == 10)
        {
            somBotao.PlayBotao();
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);

        }
        else if (notaFinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaFinal >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

    }

}
