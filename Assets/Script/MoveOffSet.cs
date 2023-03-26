using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffSet : MonoBehaviour
{
	private Material materialAtual;
	public float velocidade;
	private float offset;

	// Use this for initialization
	public void Start()
	{
		materialAtual = GetComponent<Renderer>().material;

	}

	// Update is called once per frame
	public void FixedUpdate()
	{

		offset += 0.01f;

		materialAtual.SetTextureOffset("_MainTex", new Vector2(offset * velocidade, 0));

	}
}
