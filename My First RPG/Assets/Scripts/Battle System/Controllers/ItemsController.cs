using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    public EventsChatController eventsChatController;

    public int itemLimit = 20;

    [Header("Paladin Weapons")]
    public int copperPaladinSabre;

    [Header("Paladin Armor")]

    public int amberTiara;
    public int velvetCape;
    public int copperPaladinArmor;


    [Header("Wizard Weapons")]

    public int pineWizardStaff;

    [Header("Wizard Armor")]

    public int brinkWizardHat;
    public int brinkWizardRobe;
    public int brinkWizardArmor;


    [Header("Potions")]

    public int lesserHealthPotion;
    public int healthPotion;
    public int greaterHealthPotion;


       
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AddOneItem(string item)
    {
        // Paladin Weapons

        if (item == "Copper Sabre" && copperPaladinSabre < itemLimit)
        {
            if (copperPaladinSabre >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                copperPaladinSabre += 1;
                eventsChatController.SendMessageToChat("<color=#F6B675>Copper Sabre. </color>");
            }

            return;
        }


        // Paladin Armor

        if (item == "Amber Tiara")
        {
            if (amberTiara >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                amberTiara += 1;
                eventsChatController.SendMessageToChat("Amber Tiara.");
            }

            return;
        }


        if (item == "Velvet Cape")
        {
            if (velvetCape >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                velvetCape += 1;
                eventsChatController.SendMessageToChat("Velvet Cape.");
            }

            return;
        }


        if (item == "Copper Armor")
        {
            if (copperPaladinArmor >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                copperPaladinArmor += 1;
                eventsChatController.SendMessageToChat("Copper Armor.");
            }

            return;
        }

        // Wizard Weapons

        if (item == "Pine Wizard Staff")
        {
            if (pineWizardStaff >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                pineWizardStaff += 1;
                eventsChatController.SendMessageToChat("Pine Staff.");
            }

            return;
        }

        // Wizard Armor

        if (item == "Brink Wizard Hat")
        {
            if (brinkWizardHat >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                brinkWizardHat += 1;
                eventsChatController.SendMessageToChat("Brink Wizard Hat.");
            }

            return;
        }


        if (item == "Brink Wizard Robe")
        {
            if (brinkWizardRobe >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                brinkWizardRobe += 1;
                eventsChatController.SendMessageToChat("Brink Wizard Robe.");
            }

            return;
        }


        if (item == "Brink Wizard Armor")
        {
            if (brinkWizardArmor >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                brinkWizardArmor += 1;
                eventsChatController.SendMessageToChat("Brink Wizard Armor.");
            }

            return;
        }

        // Potions            


        if (item == "Lesser Health Potion")
        {
            if (lesserHealthPotion >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                lesserHealthPotion += 1;
                eventsChatController.SendMessageToChat("<color=#FF7C7C>Lesser Health Potion.</color>");
            }

            return;
        }


        if (item == "Health Potion")
        {
            if (healthPotion >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                healthPotion += 1;
                eventsChatController.SendMessageToChat("<color=#FF7C7C>Health Potion.</color>");
            }

            return;
        }


        if (item == "Greater Health Potion")
        {
            if (greaterHealthPotion >= itemLimit)
            {
                return;
                //eventsChatController.SendMessageToChat("You have too many of this item.");
            }

            else
            {
                greaterHealthPotion += 1;
                eventsChatController.SendMessageToChat("<color=#FF7C7C>Greater Health Potion.</color>");
            }

            return;
        }

        Debug.Log("Item not found. You misspelled the item name on Loot controller");
    }

    public void RemoveOneItem(string item)
    {
        // Paladin Weapons

        if (item == "copperPaladinSabre") { copperPaladinSabre -= 1; };

        // Paladin Armor

        if (item == "amberTiara") { amberTiara -= 1; };
        if (item == "velvetCape") { velvetCape -= 1; };
        if (item == "copperPaladinArmor") { copperPaladinArmor -= 1; };

        // Wizard Weapons

        if (item == "pineWizardStaff") { pineWizardStaff -= 1; };

        // Wizard Armor

        if (item == "brinkWizardHat") { brinkWizardHat -= 1; };
        if (item == "brinkWizardRobe") { brinkWizardRobe -= 1; };
        if (item == "brinkWizardArmor") { brinkWizardArmor -= 1; };

        // Potions            

        if (item == "lesserHealthPotion") { lesserHealthPotion -= 1; };
        if (item == "healthPotion") { healthPotion -= 1; };
        if (item == "greaterHealthPotion") { greaterHealthPotion -= 1; };   }

}
