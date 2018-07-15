using UnityEngine;

public class OnStartHeroClassSetter : MonoBehaviour
{
	public Hero Hero;
	public HeroClassConfig HeroClassConfig;

	private bool _isSet = false;
	
	// Use this for initialization
	private void Update()
	{
		if (_isSet || !Input.GetKey(KeyCode.E)) return;
		
		ClassSetter.SetClassToHero(Hero, HeroClassConfig);
		_isSet = true;
		Destroy(gameObject);
	}
	
}
