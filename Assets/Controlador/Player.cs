using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//Variaveis
	public string _nome;
	public int _pontos = 0;
	public string _data = System.DateTime.Now.ToString("dd/MM/yyyy");

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Salvar()
	{
		PlayerPrefs.SetString ("Nome: ",_nome);
		PlayerPrefs.SetInt ("Pontos: ",_pontos);
		if(PlayerPrefs.HasKey("Data: ").Equals(false))
		{
			PlayerPrefs.SetString("Data: ",_data);
		}
	}

	public bool Carregar()
	{
		if(PlayerPrefs.HasKey("Data: "))
		{
			_nome = PlayerPrefs.GetString("Nome: ");
			_pontos = PlayerPrefs.GetInt("Pontos: ");
			_data = PlayerPrefs.GetString("Data: ");
			return true;
		}
		return false;
	}

	public void DeletarDados()
	{
		PlayerPrefs.DeleteKey ("Nome: ");
		PlayerPrefs.DeleteKey ("Pontos: ");
		PlayerPrefs.DeleteKey ("Data: ");
	}
}
