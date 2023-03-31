using UnityEngine;


public class PickupItem : MonoBehaviour
{
    public GameItemBase item;
    public GameItemBase Pickup()
    {
        // returns the item type and destroys the game object
        Destroy(gameObject);
        print("Picked Up :) " + item.Name);
        return item;
    }
}
