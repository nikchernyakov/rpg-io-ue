using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroWeapon : MonoBehaviour
{

	private Animator _animator;
	
	// Use this for initialization
	void Start ()
	{
		_animator = GetComponent<Animator>();
	}

	public void OnAttackSkill()
	{
		_animator.SetTrigger("AttackSkill");
	}
}
