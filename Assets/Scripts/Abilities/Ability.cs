using UnityEngine;

public abstract class Ability<T> : MonoBehaviour
    where T : IAbilityCaster
{
    public float AbilityCooldown;

    protected T AbilityCaster;
    private bool _inCooldown = false;
    private float _currentCooldown;

    public void SetAbilityCaster(T abilityCaster)
    {
        AbilityCaster = abilityCaster;
    }
    
    // Update is called once per frame
    private void Update()
    {
        if (_inCooldown)
        {
            CheckCooldown();
        }
    }

    private void CheckCooldown()
    {
        if (_currentCooldown > 0)
        {
            _currentCooldown -= Time.deltaTime;
        }
        else
        {
            _inCooldown = false;
            _currentCooldown = 0;
        }
    }

    public bool IsInCooldown()
    {
        return _inCooldown;
    }

    public void Use()
    {
        if (_inCooldown)
        {
            Debug.Log("Ability in cooldown");
            return;
        }
        
        AbilityAction();
        _inCooldown = true;
        _currentCooldown = AbilityCooldown;
    }

    protected abstract void AbilityAction();
}