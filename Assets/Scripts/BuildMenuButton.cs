using UnityEngine;
using System.Collections;

public class BuildMenuButton : MonoBehaviour
{   
    [SerializeField]
    private GameObject _Tower;
    [SerializeField]
    private int _Cost;



    void OnMouseDown()
    {   
        //check if player has enough gold
        if(Bank.Gold >= _Cost)
        {
            Bank.Gold -= _Cost;

            //spawn tower
            Transform spawn = transform.parent.parent;
            Instantiate(_Tower, spawn.position, Quaternion.identity);

            //disable menu
            spawn.gameObject.SetActive(false);
         }

        

    }
}
