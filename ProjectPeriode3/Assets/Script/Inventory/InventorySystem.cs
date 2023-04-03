using UnityEngine;
using static UnityEditor.Progress;



public class InventorySystem : MonoBehaviour
{
    public GameItemBase[] items;     //array inventory
    public int maxSlots = 10;        //max size inventory

    private void Start()
    {
        items = new GameItemBase[maxSlots]; //maakt array bij start
    }

    // https://gamedevbeginner.com/scriptable-objects-in-unity/
    public void AddItem(PickupItem collectable)
    {
        for (int i = 0; i < items.Length; i++) //start met 0, is kleiner dan lengte array, loop
        {
            if (items[i] == null)
            {
                // There is space for the item, collect it & destroy the original
                items[i] = collectable.Pickup();
                return;
            }
        }
        // There is no space, don't collect the item
    }
}