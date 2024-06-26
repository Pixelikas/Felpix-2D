using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptPrincipal : MonoBehaviour {

	public GameObject objetoCanos;
	public Text textoPontuacao;
	public Text textoMensagem;

	int pontuacao;
	public bool terminouJogo;

	// Use this for initialization
	void Start () {
		textoPontuacao.gameObject.SetActive (false);
		textoMensagem.gameObject.SetActive (true);
			
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && terminouJogo) {
			SceneManager.LoadScene ("cenaJogoFelpix");
		}

	}

	public void ComecouJogo(){

		InvokeRepeating("CriaCanos", 0f, 1.5f); //Tempo para o primeiro cano aparecere tempo de intervalo entre eles
		textoPontuacao.gameObject.SetActive (true);
		textoMensagem.gameObject.SetActive (false);
	}

	void CriaCanos()
	{
		float randomPos = (3.0f * Random.value) - 1.5f;
		GameObject cano = Instantiate(objetoCanos);
		cano.transform.localScale = new Vector3 (1.65f, 1.65f, 1.65f);
		cano.transform.position = new Vector3 (10, randomPos, 0);
	}

	public void FimDeJogo(){
		CancelInvoke ("CriaCanos");
		foreach (GameObject objeto in GameObject.FindGameObjectsWithTag("ImagemFundo")) 
		{
			objeto.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		}

		foreach (GameObject objeto in GameObject.FindGameObjectsWithTag("AreaVao"))
		{
			objeto.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		}

		Invoke ("setLabelsFinais", 2);

	}


	public void marcaPonto()
	{
		pontuacao++;
		textoPontuacao.text = pontuacao.ToString ();
	}

	void setLabelsFinais()
	{
		textoMensagem.gameObject.SetActive (true);
		textoMensagem.text = "";
		textoMensagem.color = new Color (0.15f, 0.35f, 0.55f, 1);
		terminouJogo = true;
	}
}