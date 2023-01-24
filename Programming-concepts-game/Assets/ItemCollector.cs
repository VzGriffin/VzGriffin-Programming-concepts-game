using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Emerald = 0;


    [SerializeField] private Text EmeraldText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Emerald"))
        {
            Destroy(collision.gameObject);
            Emerald++;
            EmeraldText.text = "Emeralds " + Emerald;
        }
    }
}
