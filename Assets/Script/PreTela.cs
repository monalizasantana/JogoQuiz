using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreTela : MonoBehaviour
{
    public int tempoEsperar;
    public void Start()
    {
        StartCoroutine("Esperar");

    }

    public IEnumerator Esperar()
    {
        yield return new WaitForSeconds(tempoEsperar);
        SceneManager.LoadScene("telaInicial");
    }
}
