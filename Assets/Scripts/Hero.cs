using UnityEngine;

public class Hero : Liveble, IAbilityCaster
{
    public HeroClassAbilities ClassAbilities;
    public GameObject Weapon;

    private HeroMoveControl _heroMoveControl;
    private Quaternion _startRotation;
    
    void Start()
    {
        _startRotation = transform.rotation;
        _heroMoveControl = GetComponent<HeroMoveControl>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckAttackAbilityButton();
    }

    private void CheckAttackAbilityButton()
    {
        if (Input.GetMouseButton(0))
        {
            OnAttackAbilityUsed();
        }
    }

    private void OnAttackAbilityUsed()
    {
        ClassAbilities.AttackAbility.Use();
    }

    public void SetMoveConfig(MoveConfig moveConfig)
    {
        _heroMoveControl.MoveConfig = moveConfig;
    }

    public void InitClassAbilities(HeroClassAbilities classAbilities)
    {
        ClassAbilities = classAbilities;
        foreach (var heroAbility in ClassAbilities.GetAbilityList())
        {
            heroAbility.SetAbilityCaster(this);
        }
    }

    public void InitWeapon(GameObject weapon)
    {
        // Set start rotation and save current
        var currentRotation = transform.rotation;
        transform.rotation = _startRotation;
        
        // Create weapon and set transform for him
        Weapon = Instantiate(weapon);
        Weapon.transform.parent = transform;
        Weapon.transform.position = new Vector2(transform.position.x + weapon.transform.position.x,
            transform.position.y + weapon.transform.position.y);
        
        // Return curent rotation
        transform.rotation = currentRotation;
    }
}