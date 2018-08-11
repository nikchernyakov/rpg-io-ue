using UnityEngine;

[RequireComponent(typeof(Liveble))]
[RequireComponent(typeof(HeroMoveControl))]
public class Hero : MonoBehaviour, IAbilityCaster
{
    public HeroClassAbilities ClassAbilities;
    public HeroWeapon Weapon;
    public Transform LookPosition;

    private HeroMoveControl _heroMoveControl;
    private Quaternion _startRotation;
    private Liveble _liveble;

    public Liveble GetLiveble()
    {
        return _liveble;
    }
    
    private void Awake()
    {
        _heroMoveControl = GetComponent<HeroMoveControl>();
        _liveble = GetComponent<Liveble>();
    }

    void Start()
    {
        _startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (ClassAbilities != null)
        {
            CheckAttackAbilityButton();
        }
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
        ClassAbilities = Instantiate(classAbilities);
        ClassAbilities.transform.parent = transform;
        foreach (var heroAbility in ClassAbilities.GetAbilityList())
        {
            heroAbility.SetAbilityCaster(this);
        }
    }

    public void InitWeapon(HeroWeapon weapon)
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

    public float GetLookAngle()
    {
        return MathUtils.GetPointOnTargetLookAngle(transform.position, LookPosition.position);
    }

    public void SetHpConfig(HpConfig hpConfig)
    {
        _liveble.HpConfig = hpConfig;
        _liveble.InitHp();
    }
}