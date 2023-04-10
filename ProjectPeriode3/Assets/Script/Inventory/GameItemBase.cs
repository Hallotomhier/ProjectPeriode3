using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "GameItem", order = 1)]

public class GameItemBase : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite icon;
    public GameObject gameObject;
}
