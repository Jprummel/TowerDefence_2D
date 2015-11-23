using UnityEngine;
using System.Collections;

public class ChooseTower : MonoBehaviour
{
    [SerializeField]
    private GameObject _spot;
    private bool _isPlaced;
    public bool IsPlaced {
        get {
            return _isPlaced;
        }
    }

    public void SpawnTower(GameObject tower)
    {
            if (!_isPlaced)
            {
                Instantiate(tower, _spot.transform.position, Quaternion.identity);
                Debug.Log("Hey");
                _isPlaced = true;
            }
    }
}
