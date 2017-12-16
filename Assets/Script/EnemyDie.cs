using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyDie : MonoBehaviour {

    [SerializeField]
    GameObject mExplosionPrefab;
    public int health = 1;
   
    public Text ScoreText;
    public static int score=0;
    bool startSceneTimer = false;
    float timer = 10f;


   void OnTriggerEnter2D()
   {
       health--;
        score++;
       GameObject.Find("ScoreBoard").GetComponent<Text>().text = "Score:" + score;

    }
   void Update()
   {
       if (health <= 0)
       {
           Die();
            
        }
        if (startSceneTimer)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene("GameOver");

        }
   }
   void Die()
   {
        Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
       
        Destroy(gameObject);
        startSceneTimer = true;

       
   }
    
}
