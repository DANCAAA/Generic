using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librery for ui stuff
using UnityEngine.UI;

public class CountPoints : MonoBehaviour
{
    private int count;
    public Text countText;
    public Text winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 1)
        {
            winText.text = "You Win!";
        }
    }
}
