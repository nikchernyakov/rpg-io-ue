using System.Collections.Generic;
using UnityEngine;

public class HeroClassGetter : MonoBehaviour
{
	public HeroClassConfig NoneClassConfig;
	public HeroClassConfig WarriorClassConfig;
	
	private Dictionary<HeroClassEnum, HeroClassConfig> _heroClassDictionary;

	private void Start()
	{
		_heroClassDictionary = new Dictionary<HeroClassEnum, HeroClassConfig>()
		{
			{HeroClassEnum.NONE, NoneClassConfig},
			{HeroClassEnum.WARRIOR, WarriorClassConfig}
		};
	}

	public HeroClassConfig GetClassConfig(HeroClassEnum heroClass)
	{
		return _heroClassDictionary[heroClass];
	}
}
