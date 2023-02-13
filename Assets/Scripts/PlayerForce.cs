using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{
    public Rigidbody2D larmBody;
    public Rigidbody2D rarmBody;
    public Rigidbody2D llegBody;
    public Rigidbody2D rlegBody;

    public float power;

    public AudioSource mySource;
    public AudioClip jumpClip;

    Rigidbody2D mainBody;

    // Start is called before the first frame update
    void Start()
    {
        mainBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            larmBody.AddForce(transform.up * power, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rarmBody.AddForce(transform.up * power, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            llegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            rlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            mySource.PlayOneShot(jumpClip);
            mainBody.velocity = new Vector3(0, 5, 0);

        }

        if (Input.GetKey(KeyCode.Q))
        {
            mainBody.velocity = new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            mainBody.velocity = new Vector3(1, 0, 0);
        }
    }
}
