using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    TMP_Dropdown dropdown;
    public TMPro.TextMeshProUGUI currentSelection;
    public static CharacterControl Instance;
    public List<Villager> villagerList = new List<Villager>();
    private void Start()
    {
        Instance = this;
    }
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.currentSelection.text = villager.ToString();
    }
    public void DropdownChanged(Int32 value)
    {
        SetSelectedVillager(villagerList[value]);
    }

    //private void Update()
 //   {
 //       if(SelectedVillager != null)
//        {
  //          currentSelection.text = SelectedVillager.GetType().ToString();
   //     }
  //  }
}
