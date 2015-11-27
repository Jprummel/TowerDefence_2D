using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoldCounter : MonoBehaviour
{
    private Text _goldCount;

    void Start()
    {
        _goldCount = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        _goldCount.text = "Gold: " + Bank.Gold;
    }
}
