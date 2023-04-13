using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadData : MonoBehaviour
{
    public int i;

    public void SavePlayer()
    {
        PlayerPrefs.SetFloat(i.ToString() + "PlayerX", transform.position.x);
        PlayerPrefs.SetFloat(i.ToString() + "PlayerY", transform.position.y);
        PlayerPrefs.SetFloat(i.ToString() + "PlayerZ", transform.position.z);

        Debug.Log("Player data saved");
    }

    public void LoadPlayer()
    {
        Vector3 position = new Vector3
            (
                PlayerPrefs.GetFloat(i.ToString() + "PlayerX"),
                PlayerPrefs.GetFloat(i.ToString() + "PlayerY"),
                PlayerPrefs.GetFloat(i.ToString() + "PlayerZ")
            );
            transform.position = position;
        Debug.Log("Loaded");
    }
}
