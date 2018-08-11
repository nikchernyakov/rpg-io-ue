public static class ClassSetter
{
    public static void SetClassToHero(Hero hero, HeroClassConfig heroClassConfig)
    {
        hero.SetMoveConfig(heroClassConfig.MoveConfig);
        hero.SetHpConfig(heroClassConfig.HpConfig);
        hero.InitClassAbilities(heroClassConfig.ClassAbilities);

        if (heroClassConfig.Weapon != null)
        {
            hero.InitWeapon(heroClassConfig.Weapon);
        }
    }
}