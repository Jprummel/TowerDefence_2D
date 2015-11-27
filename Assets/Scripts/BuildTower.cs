using UnityEngine;
using System.Collections;

public class BuildTower : MonoBehaviour
{
    [SerializeField]
    private GameObject buildMenu;

    void OnMouseDown()
    {
        buildMenu.SetActive(!buildMenu.activeSelf);
    }

}
