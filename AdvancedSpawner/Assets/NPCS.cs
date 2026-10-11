using UnityEngine;

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner
}

public class Farmer : INPC
{
    public void Speak()
    {
        Debug.Log("Do you want to buy something?");
    }
}