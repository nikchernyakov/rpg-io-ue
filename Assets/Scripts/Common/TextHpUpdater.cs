using UnityEngine;

[RequireComponent(typeof(TextShower))]
public class TextHpUpdater : MonoBehaviour, IHpUpdater
{
	
	private TextShower _textShower;
	
	// Use this for initialization
	private void Awake ()
	{
		_textShower = GetComponent<TextShower>();
	}

	public void UpdateHp(int currentHp)
	{
		_textShower.UpdateText(currentHp.ToString());
	}

	public void InitHp(int hp)
	{
		_textShower.Show(hp.ToString());
	}
}
