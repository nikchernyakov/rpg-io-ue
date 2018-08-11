using UnityEngine;
using UnityEngine.UI;

public class TextShower : MonoBehaviour
{
	private Text _text;

	private void Awake()
	{
		_text = GetComponent<Text>();
	}

	public void Show(string text)
	{
		_text.text = text;
	}
	
	public void UpdateText(string text)
	{
		Show(text);
	}
}
