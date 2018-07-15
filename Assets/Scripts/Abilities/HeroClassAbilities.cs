using System.Collections.Generic;
using UnityEngine;

public class HeroClassAbilities : MonoBehaviour
{
    public HeroAbility AttackAbility;

    public IEnumerable<HeroAbility> GetAbilityList()
    {
        return new List<HeroAbility>() {AttackAbility};
    } 
}
