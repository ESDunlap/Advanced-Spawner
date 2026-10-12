using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public GameObject beggarSprite;
    public GameObject farmerSprite;
    public GameObject shopownerSprite;
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                {
                    GameObject prefab = beggarSprite;
                    Vector3 randomLocation = new Vector3(Random.Range(-10.0f, 10.0f),
                    1f,
                    Random.Range(-10.0f, 10.0f));
                    Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0f, 360.0f), 0);
                    var finishedNPC = Instantiate(prefab, randomLocation, Quaternion.identity);
                    finishedNPC.transform.rotation = randomRotation;
                    return finishedNPC.GetComponent<INPC>();
                }
            case NPCType.Farmer:
                {
                    GameObject prefab = farmerSprite;
                    Vector3 randomLocation = new Vector3(Random.Range(-10.0f, 10.0f),
                    1f,
                    Random.Range(-10.0f, 10.0f));
                    var finishedNPC = Instantiate(prefab, randomLocation, Quaternion.identity);
                    return finishedNPC.GetComponent<INPC>();
                }
            case NPCType.Shopowner:
                {
                    GameObject prefab = shopownerSprite;
                    Vector3 randomLocation = new Vector3(Random.Range(-10.0f, 10.0f),
                    1f,
                    Random.Range(-10.0f, 10.0f));
                    Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0f, 360.0f), 0);
                    var finishedNPC = Instantiate(prefab, randomLocation, Quaternion.identity);
                    finishedNPC.transform.rotation = randomRotation;
                    return finishedNPC.GetComponent<INPC>();
                }
        }
        return null;
    }
}
