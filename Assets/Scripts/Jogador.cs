using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

	private float moverHorizontal;
	private float moverVertical;
	private Vector2 mover;
	private Rigidbody2D rb2d;
	private AudioSource audioSource;

	// A informação SerializeField significa 
	// que mesmo sendo private o atributo será visível na Unity
	[SerializeField]
	private float velocidade;

	[SerializeField]
	private GameObject instanciarBombas;

	[SerializeField]
	private GameObject prefabBomba;

	private float controle;

	[SerializeField]
	private float atirarTempo;

	// Use this for initialization
	// Onde geralmente onde se inicializam as variáveis
	void Start () {

		controle = 0f;
		rb2d = GetComponent<Rigidbody2D>();
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	// Essa função é chamada a cada frame
	// Se o jogo rodar a 60 fps, a função será
	// chamada 60 vezes, porém em intervalos irregulares
	void Update () {
		
	}

	// Essa não depende de frames por segundo como a anterior,
	// neste caso ela trabalha com intervalos fixos de tempo.
	// Também é utilizada para fazer cálculos físicos ou
	// quando existe um cálculo que é muito lento.
	void FixedUpdate()
	{
		moverHorizontal = Input.GetAxis("Horizontal");
		moverVertical = Input.GetAxis("Vertical");        
		mover = new Vector2(moverHorizontal,moverVertical);
		rb2d.velocity = mover * velocidade;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if(Time.time > controle)
			{
				controle = Time.time + atirarTempo;
				
				//Para instanciar o objeto Bomba os parâmetros são:
				// - Quem é o objeto;
				// - De onde ele começa;
				// - Para onde ele vai (a direção)
				Instantiate(prefabBomba, instanciarBombas.transform.position, prefabBomba.transform.rotation);

				//
				audioSource.Play();
			}
			
		}

		//Debug.Log(rb2d.velocity);
	}
}
