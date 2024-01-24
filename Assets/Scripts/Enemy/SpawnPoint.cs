using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Target _target;

    private void Start()
    {
        Instantiate(_enemy, transform.position, Quaternion.identity);
        _enemy.Target = _target;
    }
}
