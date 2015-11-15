using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]

public class TowerLevel
{
    public int _cost;
    public GameObject _visualization;
}

public class TowerUpgrade : MonoBehaviour {
    public List<TowerLevel> levels;
}


