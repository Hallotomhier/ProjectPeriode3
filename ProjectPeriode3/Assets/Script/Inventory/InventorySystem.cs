using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "test", menuName = "Inventory", order = 1)]

public class InventorySystem : ScriptableObject
{
    public GameItemBase[] Inventory;
}
