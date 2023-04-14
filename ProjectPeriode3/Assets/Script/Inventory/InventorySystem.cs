using UnityEditorInternal.Profiling.Memory.Experimental;
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
        GameItemBase pickedUpRepairKit = collectable.Pickup();
        if (slot1.repairKit == null)
        {
            slot1.repairKit = pickedUpRepairKit;
            slot1.image.sprite = pickedUpRepairKit.icon;
        }
        else if (slot2.repairKit == null)
        {
            slot2.repairKit = pickedUpRepairKit;
            slot2.image.sprite = pickedUpRepairKit.icon;
        }
        else if (slot3.repairKit == null)
        {
            slot3.repairKit = pickedUpRepairKit;
            slot3.image.sprite = pickedUpRepairKit.icon;
        }
        else if (slot4.repairKit == null)
        {
            slot4.repairKit = pickedUpRepairKit;
            slot4.image.sprite = pickedUpRepairKit.icon;
        }
        else if (slot5.repairKit == null)
        {
            slot5.repairKit = pickedUpRepairKit;
            slot5.image.sprite = pickedUpRepairKit.icon;
        }
    }
}