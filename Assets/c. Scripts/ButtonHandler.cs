using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour 
{

    public GameObject[] objectsToSpawn; //Array of objects to spawn, this will be the Buttons
    public Transform[] spawnPoints; //Array of spawnpoints, this will be where the Buttons spawn
    public int maxSpawnCount = 3; //Maximum Number of objects to spawn at each point.
    private int i;

    void Start() 
    {
        SpawnObjects();    
    }

    void SpawnObjects() 
    {
        foreach (Transform spawnpoint in spawnPoints)
        {
            Shuffle(objectsToSpawn); //Shuffles the Buttons for Random Selection

            for (int i = 0; i < Mathf.Min(maxSpawnCount, objectsToSpawn.Length); i++) //Spawn up to the Maximum Number of Objects
            {
                Instantiate(objectsToSpawn[i], spawnpoint.position, Quaternion.identity); ///Spawn the desired object
            }           
        }
    }

    void Shuffle(GameObject[] array) 
    { 
        for(int i = array.Length -1; i>0; i--) 
        {
            int randomIndex = Random.Range(0, i + 1);
            GameObject temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }    
    }
}