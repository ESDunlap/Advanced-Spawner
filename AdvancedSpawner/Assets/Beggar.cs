using UnityEngine;

public class Beggar : MonoBehaviour, INPC
{
    public void Speak()
    {
        Debug.Log("Do you have some spare change?");
    }
}