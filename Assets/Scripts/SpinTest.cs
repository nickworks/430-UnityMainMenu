using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinTest : MonoBehaviour
{
    public RectTransform needle;

    PlayerMovement player;

    void Start()
    {
        // searching for any object with playermovement on it
        // set that object as player
        player = GameObject.FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        //needle.localRotation = Quaternion.Euler(0, 0, player.dir);
    }
}
