using UnityEngine;

[RequireComponent(typeof(Dieble))]
public class Liveble : MonoBehaviour
{
	public HpConfig HpConfig;
	private int _currentHp;
	private Dieble _dieble;
		
	// Use this for initialization
	private void Start () {
		InitHp();
		_dieble = GetComponent<Dieble>();
	}
	
	// Update is called once per frame
	private void Update () {
		CheckHp();
	}

	private void InitHp()
	{
		_currentHp = HpConfig.Hp;
	}

	private void IncreaseHp(int hp)
	{
		_currentHp = Mathf.Clamp(_currentHp + hp, 0, HpConfig.Hp);
	}
		
	private void DecreaseHp(int hp)
	{
		_currentHp = Mathf.Clamp(_currentHp - hp, 0, HpConfig.Hp);
	}

	private void CheckHp()
	{
		if (_currentHp <= 0)
		{
			_dieble.Die();
		}
	}
}