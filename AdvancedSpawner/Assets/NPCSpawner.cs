using UnityEngine;
using System.Collections.Generic;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private List<INPC> allVillagers = new List<INPC>();

    public GameObject shopownerSprite;

    public void Update()
    {
        foreach(INPC villager in allVillagers)
        {
            villager.Move();
        }
    }

    public void SpawnVillagers()
    {
        INPC m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        INPC m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        INPC m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);

        m_Beggar.Spawn();
        m_Farmer.Spawn();
        m_Shopowner.Spawn();

        allVillagers.Add(m_Beggar);
        allVillagers.Add(m_Farmer);
        allVillagers.Add(m_Shopowner);
    }

    public void SpawnBeggar()
    {
        INPC m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Beggar.Spawn();
        allVillagers.Add(m_Beggar);
    }

    public void SpawnFarmer()
    {
        INPC m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Farmer.Spawn();
        allVillagers.Add(m_Farmer);
    }

    public void SpawnShopowner()
    {
        INPC m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Shopowner.Spawn();
        allVillagers.Add(m_Shopowner);
    }
}
