using UnityEngine;


public class PickupItem : MonoBehaviour
{
    public GameItemBase item;

    public GameItemBase Pickup()
    {
        Destroy(gameObject);

        print("Picked Up :) " + item.itemName);

        return item;
    }
}
