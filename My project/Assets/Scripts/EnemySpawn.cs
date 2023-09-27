using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
  public List<GameObject> Enemies = new List<GameObject>();

  public float SpawnRate;

  private float x, y;
  private Vector3 SpawnPos;

    private void Start()
    {
        StartCoroutine(SpawnTestEnemy());
    }
    IEnumerator SpawnTestEnemy() 
    {
        x = Random.Range(-1, 1);
        y = Random.Range(-1, 1);
        SpawnPos.x += x;
        SpawnPos.y += y;
        Instantiate(Enemies[0], SpawnPos, Quaternion.identity);
        yield return new WaitForSeconds(SpawnRate);
        StartCoroutine(SpawnTestEnemy());
    }
}
