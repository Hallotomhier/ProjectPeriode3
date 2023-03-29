using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "GameItem", order = 1)]

public class GameItemBase : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite Icon;
    public GameObject GameObject;

}
