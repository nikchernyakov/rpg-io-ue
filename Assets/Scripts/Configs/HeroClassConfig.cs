using UnityEngine;

[CreateAssetMenu(fileName = "HeroClassConfig", menuName = "Create HeroClassConfig")]
public class HeroClassConfig : ScriptableObject
{
    public HpConfig HpConfig;
    public MoveConfig MoveConfig;
    public HeroClassAbilities ClassAbilities;
    public GameObject Weapon;
}