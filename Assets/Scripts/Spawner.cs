using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField] private Vector2 _range;
   [SerializeField] private GameObject _enemy;
   [SerializeField] private GameObject _bonus;
    private void Start()
   {
       StartCoroutine(SpwanEnemy());
       StartCoroutine(SpawnBouns());
   }

   private IEnumerator SpwanEnemy()
   {
       yield return new WaitForSeconds(1);
       Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
       Instantiate(_enemy, spawnPos, Quaternion.identity );
       StartCoroutine(SpwanEnemy());
   }

   private IEnumerator SpawnBouns()
   {
       yield return new WaitForSeconds(1.5f);
       Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_bonus, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnBouns());
   }
}
