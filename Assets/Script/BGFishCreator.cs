using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGFishCreator : MonoBehaviour {

	public GameObject Player;
    public GameObject[] enemy;
    public float spawnTime = 3f;
    public Transform spawnPoints;

    void Start()
    {
      
        InvokeRepeating("Spawn", spawnTime,Random.Range(0,6) );

    }

    void Spawn()
    {
        if (!Player)
        {
            
            return;
        }
        Debug.Log("enemy");

        //int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int enemyIndex = Random.Range (0, enemy.Length);

		Vector3 EnemyPos = new Vector3(spawnPoints.position.x, Random.Range (4.66f, -3.74f), spawnPoints.transform.position.z);
		Instantiate(enemy[enemyIndex],EnemyPos,spawnPoints.rotation);
        

       

    }
}