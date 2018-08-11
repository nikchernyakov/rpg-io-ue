using UnityEngine;

public class HeroManager : MonoBehaviour
{

	public Hero HeroPrefab;
	public Transform SpawnPlace;
	
	private HeroCreator _heroCreator;
	private HeroClassSetManager _heroClassSetManager;
	private HeroClassEnum _currentHeroClass = HeroClassEnum.NONE;

	private Hero _heroInstance;
	
	// Use this for initialization
	void Start ()
	{
		_heroCreator = GetComponent<HeroCreator>();
		_heroClassSetManager = GetComponent<HeroClassSetManager>();
		_heroInstance = _heroCreator.Create(HeroPrefab, SpawnPlace, _currentHeroClass);
		
		
		_heroClassSetManager.SetHero(_heroInstance);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
