using UnityEngine;

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner
}

public class Beggar : INPC
{
    public void Speak()
    {
        Debug.Log("Do you have some spare change?");
    }
}

public class Farmer : INPC
{
    public void Speak()
    {
        Debug.Log("Do you want to buy something?");
    }
}

public class Shopowner : INPC
{
    public void Speak()
    {
        Debug.Log("You reap what you sow!");
    }
}