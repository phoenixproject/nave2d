using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

	[SerializeField]
	private float velocidade;
	[SerializeField]
	private int vida;
	[SerializeField]
	private GameObject prefabExplosao1;
	[SerializeField]
	private GameObject prefabExplosao2;
	[SerializeField]
	private GameObject prefabBomba;
	[SerializeField]
	private GameObject prefabInstanciar;

	[SerializeField]
	private int minValor;
	[SerializeField]
	private int maxValor;

	private int valorInimigo;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
