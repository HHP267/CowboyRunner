using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacleSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject[] obstacles;

    private List<GameObject> spawning = new List<GameObject>();

	// Use this for initialization
	void Awake () {
        InitializeObstacles();
        Shuffle();
    }

    void Start()
    {
        StartCoroutine(SpawnRandom());
    }

    // Update is called once per frame
    void InitializeObstacles () {
        int index = 0;

        for (int i = 0; i <= obstacles.Length * 3; i++)
        {
            GameObject obj = Instantiate(obstacles[index], new Vector3(transform.position.x, transform.position.y), Quaternion.identity) as GameObject;
            spawning.Add(obj);
            spawning[i].SetActive(false);

            index++;
            if (index == obstacles.Length)
            {
                index = 0;
            }
        } 
	}

    void Shuffle()
    {
        for (int i = 0; i < spawning.Count; i++)
        {
            GameObject temp = spawning[i];
            int random = Random.Range(i, spawning.Count);

            spawning[i] = spawning[random];
            spawning[random] = temp;
        }
    }

    IEnumerator SpawnRandom()
    {
        yield return new WaitForSeconds (Random.Range(1.5f, 4.5f));

        int i = Random.Range(0, spawning.Count);
        while (true)
        {
            if (!spawning[i].activeInHierarchy)
            {
                spawning[i].SetActive(true);
                spawning[i].transform.position = new Vector3(transform.position.x, transform.position.y);
                break;
            }
            else
            {
                i = Random.Range(0, spawning.Count);
            }
        }

        StartCoroutine(SpawnRandom());
    }











} //Spawner


































