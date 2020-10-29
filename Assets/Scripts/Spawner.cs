using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Enemey;
    [SerializeField] private Transform _spawn;
    private Transform[] _spawners;
    private int _curretSpawner;

    private void Start()
    {
        _spawners = new Transform[_spawn.childCount];

        for (int i = 0; i < _spawn.childCount; i++)
        {
            _spawners[i] = _spawn.GetChild(i);
        }

        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        var delay = new WaitForSeconds(2);
        while (true)
        {
            Instantiate(Enemey, _spawners[_curretSpawner].position, Quaternion.identity);
            _curretSpawner++;

            if (_curretSpawner >= _spawners.Length)
            {
                _curretSpawner = 0;
            }
            yield return delay;
        }
    }
}
