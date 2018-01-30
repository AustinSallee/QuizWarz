using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector2 spawnValues;
    public GameObject panel;
    public GameObject knight;
    public GameObject spawnLoc;
    public int wait;

    private void Start()
    {
        spawnLoc = GameObject.Find("KnightSpawnRight");
        StartCoroutine(spawner());
        
    }

    IEnumerator spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5,20));
            for (int i = 0; i < 1; i++)
            {
                GameObject copy=Instantiate(knight,spawnLoc.transform.position,spawnLoc.transform.rotation);
                copy.transform.SetParent(panel.transform, false);

            }
            yield return new WaitForSeconds(Random.Range(5, 20));

        }
    }
}
