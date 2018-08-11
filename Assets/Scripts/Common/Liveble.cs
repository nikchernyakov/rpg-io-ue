﻿using UnityEngine;

[RequireComponent(typeof(Dieble))]
public class Liveble : MonoBehaviour
{
	public HpConfig HpConfig;
	private int _currentHp;
	private Dieble _dieble;

	public int GetCurrentHp()
	{
		return _currentHp;
	}

	private void Awake()
	{
		_dieble = GetComponent<Dieble>();
	}

	public void InitHp()
	{
		_currentHp = HpConfig.Hp;
	}

	public void IncreaseHp(int hp)
	{
		_currentHp = Mathf.Clamp(_currentHp + hp, 0, HpConfig.Hp);
		OnHpUpdated();
	}
		
	public void DecreaseHp(int hp)
	{
		_currentHp = Mathf.Clamp(_currentHp - hp, 0, HpConfig.Hp);
		OnHpUpdated();
	}

	private void OnHpUpdated()
	{
		CheckHp();
	}

	private void CheckHp()
	{
		if (_currentHp <= 0)
		{
			_dieble.Die();
		}
	}
}