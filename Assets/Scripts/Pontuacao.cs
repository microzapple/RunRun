using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {
    public static int pontos;
    public Text pontosText;

	// Use this for initialization
	void Start ()
	{
	    pontos = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        pontosText.text = pontos.ToString();
    }
    
}
