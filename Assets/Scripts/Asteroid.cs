using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	[SerializeField]
	private Rigidbody2D rb2d;
	[SerializeField]
	private float maximo;
	[SerializeField]
	private float minimo;
	[SerializeField]
	private float velocidade;
	[SerializeField]
	private int tempoVida;
	[SerializeField]
	private int pontos;
	[SerializeField]
	private GameObject prefabExplosao1;
	[SerializeField]
	private GameObject prefabExplosao2;

	// Use this for initialization
	void Start () {
		
	}
	
	void Movimentar()
	{
		//rb2d.
	}
}
