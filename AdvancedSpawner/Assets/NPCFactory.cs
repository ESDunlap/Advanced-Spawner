using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public GameObject shopownerSprite;
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            /*case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;*/
            case NPCType.Shopowner:
                GameObject prefab = shopownerSprite;
                Vector3 randomLocation = new Vector3(Random.Range(-10.0f, 10.0f),
                1f,
                Random.Range(-10.0f, 10.0f));
                var finishedNPC = Instantiate(prefab, randomLocation, Quaternion.identity);
                return finishedNPC.GetComponent<INPC>();
        }
        return null;
    }
}
