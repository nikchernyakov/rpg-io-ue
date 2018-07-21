using UnityEngine;

public abstract class Ability<T> : MonoBehaviour
    where T : IAbilityCaster
{
    public float AbilityCooldown;

    public T AbilityCaster;
    private bool _inCooldown = false;
    private float _currentCooldown = 0;
    private bool _inAction = false;

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

        if (_inAction)
        {
            AbilityAction();
        }
    }

    private void CheckCooldown()
    {
        if (_currentCooldown > 0)
        {
            _currentCooldown -= Time.deltaTime;
        }
        else if (_inCooldown)
        {
            _inCooldown = false;
            _currentCooldown = 0;
        }
    }

    public void StopAction()
    {
        _inAction = false;
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

        _inAction = true;
        AbilityStartAction();
        
        _inCooldown = true;
        _currentCooldown = AbilityCooldown;
    }

    protected abstract void AbilityStartAction();

    protected abstract void AbilityAction();
}