using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObSpawn : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject starOb;
    public GameObject yellowstar;
    public bool gameOver = false;
    public static ObSpawn instance;

    private void Awake()
    {
        if(instance == null)
            instance = this; 

    }

    public void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn() 
    {

        while(!gameOver)
        {
            float waitTime = Random.Range(1f, 4f);
            Debug.Log(waitTime);
            if (waitTime <= 3.4f)
                SpawnObstacle();
            else if (waitTime < 3.8f)
                SpawnYellowStar();
            else
                SpawnStar();

            yield return new WaitForSeconds(waitTime);
        }
    }

    void SpawnStar()
    {
        Vector2 star = new Vector2(4f, -2.5f);
        Instantiate(starOb, star, Quaternion.identity);
        Debug.Log("spawned blue star");

    }

    void SpawnObstacle()
    {
        Vector2 v = new Vector2(4f, -3.5f);
        Instantiate(obstacle, v, Quaternion.identity);
        Debug.Log("spawned obstacle crate");
    }

    void SpawnYellowStar()
    {
        Vector2 yellowspawn = new Vector2(4f, -2.1f);
        Instantiate(yellowstar, yellowspawn, Quaternion.identity);
        Debug.Log("spawned yellow star");
    }
}
