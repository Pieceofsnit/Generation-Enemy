using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private List<Enemy> _gangEnemies;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private List<Target> _targets;
    private int _delay = 2;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        var waitForSeconds = new WaitForSeconds(_delay);

        if(_gangEnemies.Count <= _spawnPoints.Count && _gangEnemies.Count <= _targets.Count)
        {
            for (int i = 0; i < _gangEnemies.Count; i++)
            {
                var spawnRange = Random.Range(0, _spawnPoints.Count);
                Instantiate(_gangEnemies[i], _spawnPoints[spawnRange].transform.position, Quaternion.identity);
                _spawnPoints.RemoveAt(spawnRange);
                _gangEnemies[i].Target = _targets[i];
                yield return waitForSeconds;
            }
        }
    }
}
