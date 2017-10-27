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
    bool debug = false;
    void Start()
    {
        SelectKeys();
    }

    void SelectKeys()
    {
        keyOne = spawnLocationList[Random.Range(0, 6)];
        keyTwo = spawnLocationList[Random.Range(0, 6)];
        keyThree = spawnLocationList[Random.Range(0, 6)];
        if (debug)
        {
            Debug.Log(keyOne.transform.position.ToString());
            Debug.Log(keyTwo.transform.position.ToString());
            Debug.Log(keyThree.transform.position.ToString());
        }

        while (keyOne == keyTwo || keyOne == keyThree)
        {
            keyOne = spawnLocationList[Random.Range(0, 6)];
            Debug.Log(keyOne.transform.position.ToString());
        }

        while (keyTwo == keyOne || keyTwo == keyThree)
        {
            keyTwo = spawnLocationList[Random.Range(0, 6)];
            Debug.Log(keyTwo.transform.position.ToString());
        }

        while (keyThree == keyOne || keyThree == keyTwo)
        {
            keyThree = spawnLocationList[Random.Range(0, 6)];
            Debug.Log(keyThree.transform.position.ToString());
        }

        // Once keys are set to not spawn in the same location the key game objects are spawned
        Instantiate(key, keyOne.transform.position + new Vector3(0, 1, 0), keyOne.transform.rotation);
        Instantiate(key, keyTwo.transform.position + new Vector3(0, 1, 0), keyTwo.transform.rotation);
        Instantiate(key, keyThree.transform.position + new Vector3(0, 1, 0), keyThree.transform.rotation);
    }
}
