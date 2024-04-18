using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour 
{

    public GameObject[] objectsToSpawn; //Place Buttons here in the Unity Inspector
    public Transform[] spawnPoints; //Place Spawnpoints here in the Unity Inspector
    public int maxSpawnCountPerPoint = 1; //Maximum Number of Buttons on Individual Spawnpoints
    public int maxTotalSpawnCount = 3; //Total Number of Buttons that can Spawn
    private int totalSpawnedCount = 0; //Tracks the amount of spawned Buttons
    private int i;
    private List<Transform> usedSpawnPoints = new List<Transform>(); //Tracks which Spawnpoints have been used, prevents them being used twice

    void Start() 
    {
        SpawnObjects();    
    }

    void SpawnObjects() 
    {
        while (totalSpawnedCount < maxTotalSpawnCount)
        { 
            foreach (Transform spawnPoint in spawnPoints) 
            { 
                if (!usedSpawnPoints.Contains(spawnPoint)) 
                //Check if a Spawnpoint has been Used
                {
                    Shuffle(objectsToSpawn);
                    //Shuffle the GameObjects to Randomize Selection

                    int objectsToSpawnCount = Mathf.Min(maxSpawnCountPerPoint, objectsToSpawn.Length);

                    for (int i = 0; i < objectsToSpawnCount; i++) 
                    {
                        if (totalSpawnedCount >= maxTotalSpawnCount)
                        //Checks if we have reached the Maximum Total Spawned
                            break;

                        Instantiate(objectsToSpawn[i], spawnPoint.position, Quaternion.identity);
                        totalSpawnedCount++;
                    }

                usedSpawnPoints.Add(spawnPoint);
                    //Mark the Spawnpoint as Used

                if (totalSpawnedCount >= maxTotalSpawnCount)
                        break;

                }
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