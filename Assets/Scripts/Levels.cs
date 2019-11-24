using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelInfo {
    public string nameOfLevel = "";
    public string nameOfCreator = "";
    public string filenameOfScene = "";
    public Sprite imageForButton;
}

public class Levels : MonoBehaviour
{
    public LevelInfo[] levels;
}
