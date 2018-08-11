using UnityEngine;

public class HeroCreator : MonoBehaviour
{
	public AbstractHpShower HpShowerPrefab;
	public Transform HeroParentTransform;
	
	private HeroClassGetter _heroClassGetter; 
	private IHpCreator _hpHpCreator;

	private void Awake()
	{
		_heroClassGetter = GetComponent<HeroClassGetter>();
		_hpHpCreator = GetComponent<IHpCreator>();
	}

	public Hero Create(Hero heroPrefab, Transform spawnPlace, HeroClassEnum heroClass)
	{
		// Create hero and set position and parent for him
		var heroInstance = Instantiate(heroPrefab, HeroParentTransform);
		heroInstance.transform.position = spawnPlace.transform.position;
		
		// Set class for hero
		ClassSetter.SetClassToHero(heroInstance, _heroClassGetter.GetClassConfig(heroClass));
		
		// Create Hp view for hero
		_hpHpCreator.Create(HpShowerPrefab, HeroParentTransform, heroInstance.GetLiveble());
		
		return heroInstance;
	}
}
