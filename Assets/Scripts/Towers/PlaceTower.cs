using UnityEngine;
using System.Collections;

public class PlaceTower : MonoBehaviour {

    [SerializeField]
    private GameObject _towerPrefab;
    private GameObject _tower;
    
    private bool _canPlaceTower()
    {
        return _tower == null;
    }

    void OnMouseUp()
    {
        if(_canPlaceTower())
        {
            _tower = (GameObject)
                Instantiate(_towerPrefab, transform.position, Quaternion.identity);
            //Reduce player gold TODO
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
