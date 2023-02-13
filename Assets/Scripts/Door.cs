using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public GameObject win;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Win!");
            GameObject window = Instantiate(win);
            window.GetComponent<RectTransform>().SetParent(FindObjectOfType<Canvas>().transform);
        }
    }
}
