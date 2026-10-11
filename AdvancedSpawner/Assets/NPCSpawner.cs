using UnityEngine;
using System.Collections.Generic;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;

    private List<GameObject> allVillagers = new List<GameObject>();

    public GameObject shopownerSprite;

    public void SpawnVillagers()
    {
        /*m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);*/
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
    }

    public void SpawnShopowner()
    {
    }
}
