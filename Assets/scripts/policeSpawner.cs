using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class policeSpawner : MonoBehaviour
{
    [SerializeField] float wait = 1f;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [SerializeField] float maxYDistance;
    [SerializeField] float xSize;
    [SerializeField] float ySize;
    
    [SerializeField] Mover prefabToSpawn;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);

            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y  + Random.Range(-maxYDistance, +maxYDistance),
                transform.position.z);
            Mover newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, Quaternion.identity);

            newObject.SetVelocity(velocityOfSpawnedObject);
        }
    }
}
