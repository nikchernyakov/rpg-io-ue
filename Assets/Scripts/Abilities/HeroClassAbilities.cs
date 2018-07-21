using System.Collections.Generic;
using UnityEngine;

public class HeroClassAbilities : MonoBehaviour
{
    public HeroAbility AttackAbility;

    private void Start()
    {
        AttackAbility = Instantiate(AttackAbility);
        AttackAbility.transform.parent = transform;
    }

    public IEnumerable<HeroAbility> GetAbilityList()
    {
        return new List<HeroAbility>() {AttackAbility};
    } 
}
