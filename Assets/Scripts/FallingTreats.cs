using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTreats : MonoBehaviour
{
    [SerializeField]
    private GameObject[] treats = new GameObject[8];

    [SerializeField]
    private float spawnDelay = 2.0f;

    private float startTime;

    private int treatNumberToSpawn;
    private GameObject treatToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        startTime = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.deltaTime + spawnDelay >= startTime) {
            treatNumberToSpawn = Random.Range(0, treats.Length);
            treatToSpawn = treats[treatNumberToSpawn];

            Instantiate(treatToSpawn, transform.position, transform.rotation);

            startTime = Time.deltaTime;
        }
    }
}
