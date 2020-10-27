using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject Enemey;

    [SerializeField] private Transform _spawn;

    private Transform[] _spawners;
    private int _curretSpawner;
    public float _timer = 0;

    private void Start()
    {
        _spawners = new Transform[_spawn.childCount];

        for (int i = 0; i < _spawn.childCount; i++)
        {
            _spawners[i] = _spawn.GetChild(i);
        }
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >=2)
        {
            Instantiate(Enemey, _spawners[_curretSpawner].position, Quaternion.identity);
            _curretSpawner++;
            _timer = 0;
        }

        if (_curretSpawner >= _spawners.Length)
        {
            _curretSpawner = 0;
        }
    }

}
