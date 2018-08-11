using UnityEngine;

public class HeroClassSetManager : MonoBehaviour
{
	public Hero Hero;
	public HeroClassConfig HeroClassConfig;

	private HeroClassGetter _heroClassGetter;
	private bool _isSet = false;


	private void Start()
	{
		_heroClassGetter = GetComponent<HeroClassGetter>();
	}

	// Use this for initialization
	private void Update()
	{
		if (_isSet || !Input.GetKey(KeyCode.Alpha1)) return;
		
		ClassSetter.SetClassToHero(Hero, HeroClassConfig);
		_isSet = true;
		Destroy(gameObject);
	}

	public void SetHero(Hero hero)
	{
		Hero = hero;
	}

}
