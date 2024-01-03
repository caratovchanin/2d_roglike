using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;


//TODO: Add strength, agility, intellect and another.(they up some stats)

public abstract class AttributeBase
{
    public int BaseAmount;
    protected abstract void Sum(AttributeBase attributeToSum, SubAttribute attribute = null);
    public static AttributeBase operator +(AttributeBase first, AttributeBase second)
    {
        first.Sum(second);
        return first;
    } 
}

public class SubAttribute
{
    public int Speed {get; private set;}
    public int Lucky {get; private set;}
    public int RangeToPickUp {get; private set;}
    public Resistons resistons {get; private set;}
}

public class Resistons
{
    public float PhysResistons;
    public float MagicResistons;
}

public class StrengthAttribute : AttributeBase
{
    protected override void Sum(AttributeBase attributeToSum, SubAttribute subAttribute = null)
    {
        
    }
    
}

public class AgilityAttribute : AttributeBase
{
    protected override void Sum(AttributeBase attributeToSum, SubAttribute subAttribute = null)    {
        
    }
}

public class IntellectAttribute : AttributeBase
{
    protected override void Sum(AttributeBase attributeToSum, SubAttribute subAttribute = null)    {
        
    }
}

public class MainStats
{
    StrengthAttribute strength;
    AgilityAttribute agility;
    IntellectAttribute intellect;
    SubAttribute subAttribute;
}







