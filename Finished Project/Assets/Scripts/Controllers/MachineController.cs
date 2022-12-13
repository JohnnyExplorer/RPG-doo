using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

using Models.Inventory;
using Mode



/* Controls the player. Here we chose our "focus" and where to move. */

[RequireComponent(typeof(Inventory))]
[RequireComponent(typeof(CraftingMaterial))]
public class MachineController : MonoBehaviour
{
    public Inventory inventory = new();
    public Inventory output = new();
    public List<CraftingRecipe> recipes;
    public string status = "Empty";

    public List<string> AvailableInteractions =
        new() { "PutMaterials", "Empty", "GetOutPut", "Start" };

    public MachineController() { }

    public bool PutMaterials(List<CraftingMaterial> materials)
    {
        foreach (var item in materials)
        {
            try
            {
                inventory.Add(item);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"error add item inventory  {ex.Message}");
                return false;
            }
        }
        return true;
    }

    public bool Empty(Inventory playerInventory)
    {
        try
        {
            inventory.items.ForEach(i => playerInventory.Add(i));
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"error Empty item ${ex.Message}");
            return false;
        }
        return true;
    }
}
