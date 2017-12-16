using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplosionDeath : MonoBehaviour {

    [SerializeField]
    GameObject mExplosionPrefab;


    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Enemy" || Col.gameObject.tag == "Traps")
        {
            EnemyDie.score = 0;
            Destroy(Col.gameObject);
            Destroy(gameObject);
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);

            SceneManager.LoadScene("GameOver");

        }
    }
}

