using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject _enemyToSpawn;
    [SerializeField]
    private float _spawnTimer;
    [SerializeField]
    private Transform[] _Waypoints;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.5f, _spawnTimer);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnEnemy()
    {
        GameObject obj = Instantiate(_enemyToSpawn, this.transform.position, Quaternion.identity) as GameObject;
        obj.transform.SetParent(this.transform);
        obj.GetComponent<wayPointAI>().setWaypoints(_Waypoints);
    }
}
