using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LootController : MonoBehaviour
{
    [Space(10)]
    public ItemsController itemsController;

    [Space(10)]

    public BoarLootClass boarLootClass;


    float randomRangeBoarLoot;
    int countLimitBoar;
    int firstOdd;

    void Start()
    {

    }


    void Update()
    {

    }

    public void boarLoot()
    {
        firstOdd = -1;

        foreach (var item in boarLootClass.items)
        {            
            randomRangeBoarLoot = Random.Range(0, 10001);
            randomRangeBoarLoot = randomRangeBoarLoot / 100;

            if (randomRangeBoarLoot <= boarLootClass.odds[firstOdd + 1])
            {
                itemsController.AddOneItem(boarLootClass.items[firstOdd + 1]);        
            }

            firstOdd += 1;
        }

        firstOdd = -1;
    }

    public void darkBoarLoot()
    {

    }
}


[System.Serializable]
public class BoarLootClass
{
    public List<string> items;
    public List<float> odds;
    public List<Sprite> icons;

    public BoarLootClass(List<string> itemsLoot, List<float> oddsLoot, List<Sprite> iconsLoot)
    {
        this.items = itemsLoot;
        this.odds = oddsLoot;
        this.icons = iconsLoot;
    }
}

