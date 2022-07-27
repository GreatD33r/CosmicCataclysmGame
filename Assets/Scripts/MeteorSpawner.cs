using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    private float _timer;
    bool _playerReady;

    private void Start()
    {
        _timer = RandomTime();
    }

    void FixedUpdate()
    {
        if (_timer <= 0f) { CreateCar(); _timer = RandomTime(); }
        else { _timer -= Time.fixedDeltaTime; }
    }


    private void CreateCar()
    {
        GameObject currentCar = Instantiate(_allMeteor[RandomCar()], transform.position, Quaternion.identity);
    }


    [SerializeField] private int _minDelay = 1;
    [SerializeField] private int _maxDelay = 3;
    private float RandomTime()
    {
        return Random.Range(_minDelay, _maxDelay);
    }


    [SerializeField] private GameObject[] _allMeteor;
    private int RandomCar()
    {
        return Random.Range(0, _allMeteor.Length);
    }
}
