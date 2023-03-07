using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise_3 : MonoBehaviour
{
    // Counter 1+ 1- with the up and down arrow

    public int value;
    public TextMeshProUGUI _value;

    private void Update()
    {
        _value.text = $"{value}";

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            value++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            value--;
        }
    }
}
