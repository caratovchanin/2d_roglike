public abstract class DamageBase
{
    public abstract float CalcDmg(float originalDmg, float resistons);
}

public  class PhysicalDamage : DamageBase
{
    public override float CalcDmg(float originalDmg, float resistons)
    {
        return 0.05f;
    }
}

public class MagicalDamage : DamageBase
{
    public override float CalcDmg(float originalDmg, float resistons)
    {
        return 0.05f;
    }
} 

