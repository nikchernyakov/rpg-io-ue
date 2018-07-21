using System;
using UnityEngine;

public class WarriorAttackAbility : HeroAbility
{
	public float AttackPerfomanceTime = 1;
	public float AttackPerfomanceSpeed = 1;
	
	protected override void AbilityStartAction()
	{
		Debug.Log("WarriorAttackAbility used");
		AbilityCaster.Weapon.OnAttackSkill();
	}

	protected override void AbilityAction()
	{
		
	}

}
