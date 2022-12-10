using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

/* Controls the player. Here we chose our "focus" and where to move. */

[RequireComponent(typeof(Inventory))]
public class MachineController : MonoBehaviour {

    public inventory = new Inventory().instance;
    public output = new Inventory().instance;
    public List<CraftingRecipe> recipes;
    public status = "Empty"

    public AvailableInteractions = new List<string>()
    {"PutMaterials","Empty","GetOutPut","Start"};

    public MachineController() {

    }

    public PutMaterials(List<CraftingMaterial> materials) {
        foreach (var item in collection)
        {
            
        }
    }

    

    
}