using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControladorPrincipal : MonoBehaviour {

	public Player _player;
	public Text _txtNome;

	// Use this for initialization
	void Start () {
		_player = (Player)FindObjectOfType (typeof(Player));
		_txtNome.text = "Nome: " + _player._nome;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Voltar()
	{
		_player.Salvar ();
		Destroy (GameObject.Find("Player"));
		Application.LoadLevel ("Scene-Menu");
	}

	public void DeletarJogoSalvo()
	{
		_player.DeletarDados ();
		Destroy (GameObject.Find("Player"));
		Application.LoadLevel ("Scene-Menu");
	}
}
