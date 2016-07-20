using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControladorMenu : MonoBehaviour {

	public Player _player;

	public GameObject _menuBotoes;
	public GameObject _menuNovoJogo;
	public GameObject _menuMensagens;

	public InputField _nome;

	public Text _msg;
	public Text _data;

	// Use this for initialization
	void Start () {
		_data.text = "Data: "+System.DateTime.Now.ToString("dd/MM/yyyy");
		_player = (Player)FindObjectOfType (typeof(Player));
		this.AtivarMenu (1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AtivarMenu(int _id)
	{
		if(_id.Equals(1)){_menuBotoes.SetActive(true);}else{_menuBotoes.SetActive(false);};
		if(_id.Equals(2)){_menuNovoJogo.SetActive(true);}else{_menuNovoJogo.SetActive(false);};
		if(_id.Equals(3)){_menuMensagens.SetActive(true);}else{_menuMensagens.SetActive(false);};
	}

	public void Jogar()
	{
		if (PlayerPrefs.HasKey ("Data: ").Equals (false)) 
		{
			if (_nome.text.Equals ("")) 
			{
				_msg.text = "Erro: Nome Em Branco.";
				this.AtivarMenu (3);
			}
			else
			{
				_player._nome = _nome.text;
				_player.Salvar();
				Application.LoadLevel("Scene-Principal");
			}
		}
		else
		{
			_msg.text = "Erro: Ja Existe Um Jogo.";
			this.AtivarMenu(3);
		}
	}

	public void RecarregarJogo()
	{
		if (_player.Carregar ()) 
		{
			Application.LoadLevel ("Scene-Principal");
		} 
		else 
		{
			_msg.text = "Erro: Nao Tem Jogo Salvo";
			this.AtivarMenu(3);
		}
	}

	public void Sair()
	{
		Application.Quit ();
	}
}
