using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public Image image;
    public GameItemBase gameItem;

    public void PutInInv(GameItemBase newItem)
    {
        gameItem = newItem;
        image.sprite = newItem.icon;
    }
}