using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _targetPrefab;
    [SerializeField] private Transform _targetSpawnPoint;
    [SerializeField] private float _spawnDelay = 3f;
    [SerializeField] private float _spawnInterval = 1f;
    //private float _spawnTimer = 0f;

    private void Awake()
    {
        StartCoroutine(_spawnCoroutine());
    }
    private IEnumerator _spawnCoroutine()
    {
        yield return new WaitForSeconds(_spawnDelay);
        while (true)
        {
            SpawnTarget();
            yield return new WaitForSeconds(_spawnInterval);
        }
    }

    private void SpawnTarget()
    {
        Instantiate(_targetPrefab, _targetSpawnPoint.position, _targetSpawnPoint.rotation);
    }
}
