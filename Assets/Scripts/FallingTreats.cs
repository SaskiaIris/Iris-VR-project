using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTreats : MonoBehaviour
{
    [SerializeField]
    private GameObject[] treats = new GameObject[8];

    [SerializeField]
    private float spawnDelay = 2.0f;

	[SerializeField]
	private bool canSpawn = true;

    private int treatNumberToSpawn;
    private GameObject treatToSpawn;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(SpawnTreats());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTreats() {
		while(canSpawn) {

			treatNumberToSpawn = Random.Range(0, treats.Length);
			treatToSpawn = treats[treatNumberToSpawn];

			Vector3 randomRotation = transform.eulerAngles;
			randomRotation.y = Random.Range(0f, 360f);

			treatToSpawn.transform.eulerAngles = randomRotation;

			Instantiate(treatToSpawn, transform.position, treatToSpawn.transform.rotation);

			yield return new WaitForSeconds(spawnDelay);
		}
    }
}
