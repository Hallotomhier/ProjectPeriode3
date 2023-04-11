using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public InventoryItem slot1;
    public InventoryItem slot2;     
    public InventoryItem slot3;
    public InventoryItem slot4;
    public InventoryItem slot5;

    public void AddItem(PickupItem collectable)
    {
        GameItemBase repairKit = collectable.Pickup();
        if (slot1.gameItem == null)
        {
            slot1.PutInInv(repairKit);
        }
        else if (slot2.gameItem == null)
        {
            slot2.PutInInv(repairKit);
        }
        else if (slot3.gameItem == null)
        {
            slot3.PutInInv(repairKit);
        }
        else if (slot4.gameItem == null)
        {
            slot4.PutInInv(repairKit);
        }
        else if (slot5.gameItem == null)
        {
            slot5.PutInInv(repairKit);
        }
       
    }
}