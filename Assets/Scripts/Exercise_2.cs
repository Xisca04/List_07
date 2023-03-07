using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise_2 : MonoBehaviour
{
    // Timer 

    public int timer = 0;
    public TextMeshProUGUI _timer;

    private void Start()
    {
        StartCoroutine(counter());
    }

    private IEnumerator counter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            _timer.text = $"{timer}";
            timer++;
        }
    }

}
