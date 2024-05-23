using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
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
        Shuffle(spawnPoints); //Shuffle the Spawnpoints

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

    void Shuffle<T>(T[] array)
    { 
        for (int i = array.Length - 1; i > 0; i--) 
        {
            int randomIndex = Random.Range(0, i + 1);
            T temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }
}

//To use this script:
//    1. Attach this script to an Empty GameObject in your setting, this can be outside the map, inside an object, doesnt matter. You just need to be able to access it.
//    2. Place your "SpawnPoints" within your scene, name them "Spawnpoint01", "Spawnpoint02", etc, etc. Until you have your desired amount. You MUST have 3 spawnpoints minimum.
//    3. Click on your GameObject that has this script attached, ensure you have a minimum of 3 buttons in the "Objects To Spawn" dropdown menu. You can drag and drop the Button Prefab from the assets folder into the box.
//    4. Drag and drop your spawnpoints from the Unity Hierarchy, (The left side where all the objects are), into the drop down labled "Spawn Points" within the Inspector (The right side where all the info for the object with the script is)
//    5. Test, tweak, and adjust to your preffered settings for your level!
//    6. Done, Script Impleneted Successfully!

//    Love from Sonny xo

