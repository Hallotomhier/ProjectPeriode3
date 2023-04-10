using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class InventorySystem : MonoBehaviour
{
    //public GameItemBase[] items;     //array inventory
    //public int maxSlots = 5;        //max size inventory
    public InventoryItem slot1;
    public InventoryItem slot2;     
    public InventoryItem slot3;
    public InventoryItem slot4;
    public InventoryItem slot5;


    private void Start()
    {
        //items = new GameItemBase[maxSlots]; //maakt array bij start
    }

    // https://gamedevbeginner.com/scriptable-objects-in-unity/
    public void AddItem(PickupItem collectable)
    {
        if (slot1.gameItem == null)
        {
            slot1.PutInInv(collectable.Pickup());
        }
        else if (slot2.gameItem == null)
        {
            slot2.PutInInv(collectable.Pickup());
        }
        else if (slot3.gameItem == null)
        {
            slot3.PutInInv(collectable.Pickup());
        }
        else if (slot4.gameItem == null)
        {
            slot4.PutInInv(collectable.Pickup());
        }
        else if (slot5.gameItem == null)
        {
            slot5.PutInInv(collectable.Pickup());
        }
        //for (int counter = 0; counter < maxSlots; counter++) //start met 0, is kleiner dan lengte array, loop
        //{
        //    //print("ja " + counter);
        //    if (items[counter] == null)
        //    {
        //        //There is space for the item, collect it & destroy the original
        //        items[counter] = collectable.Pickup();
        //        return;
        //    }
        //}
        // There is no space, don't collect the item
    }
}