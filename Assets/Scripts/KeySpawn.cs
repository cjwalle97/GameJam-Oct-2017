using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{

    public GameObject key;
    public List<GameObject> spawnLocationList;

    public GameObject keyOne;
    public GameObject keyTwo;
    public GameObject keyThree;

    void Start()
    {
        SelectKeys();
    }

    void Update()
    {

    }

    void SelectKeys()
    {
        keyOne = spawnLocationList[Random.Range(0, 4)];
        keyTwo = spawnLocationList[Random.Range(0, 4)];
        keyThree = spawnLocationList[Random.Range(0, 4)];

        while (keyOne == keyTwo || keyOne == keyThree)
        {
            keyOne = spawnLocationList[Random.Range(0, 4)];
        }

        while (keyTwo == keyOne || keyTwo == keyThree)
        {
            keyTwo = spawnLocationList[Random.Range(0, 4)];
        }

        while (keyThree == keyOne || keyThree == keyTwo)
        {
            keyThree = spawnLocationList[Random.Range(0, 4)];
        }

        Instantiate(key, keyOne.transform.position + new Vector3(0, 1, 0), keyOne.transform.rotation);
        Instantiate(key, keyTwo.transform.position + new Vector3(0, 1, 0), keyTwo.transform.rotation);
        Instantiate(key, keyThree.transform.position + new Vector3(0, 1, 0), keyThree.transform.rotation);
    }
}
