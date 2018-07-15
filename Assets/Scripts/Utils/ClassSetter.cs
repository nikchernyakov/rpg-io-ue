
public class ClassSetter
{
    public static void SetClassToHero(Hero hero, HeroClassConfig heroClassConfig)
    {
        hero.SetMoveConfig(heroClassConfig.MoveConfig);
        hero.HpConfig = heroClassConfig.HpConfig;
        hero.InitClassAbilities(heroClassConfig.ClassAbilities);
        hero.InitWeapon(heroClassConfig.Weapon);
    }
}