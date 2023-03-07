using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    // Multiples cubes with random scales in ramdom positions

    public GameObject prefab;

    private void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            float randomX = Random.Range(-7.0f, 7.0f);
            float randomY = Random.Range(-5.0f, 5.0f);
            float randomZ = Random.Range(-1.0f, 7.0f);
            Vector3 pos = new Vector3(randomX, randomY, randomZ);
            
            GameObject go = Instantiate(prefab, pos, Quaternion.identity);
            go.transform.localScale = Vector3.one * Random.Range(0, 5); 
        }
    }

    

    /*
    private Vector3 RandomPositions()
    {
        float randomX = Random.Range(-15.0f, 15.0f);
        float randomY = Random.Range(-7.0f, 7.0f);
        float randomZ = Random.Range(-10.0f, 10.0f);

        return new Vector3(randomX, randomY, randomZ);
    }
    */

    /*
    private Vector3 RandomScale()  // Escala aleatoria 
    {
        float x = Random.Range(0.5f, 10f);
        float y = Random.Range(0.5f, 10f);

        return new Vector3(x, y, 1);
    }
    */

}
