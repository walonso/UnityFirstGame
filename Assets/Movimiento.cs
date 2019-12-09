using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        //Transform.Position += new Vector3(Input.GetAxis("Horizontal"),0,0);
        if (transform.position.x < -10)
        {
            transform.position += new Vector3(-10,-3);
        }
        else if (transform.position.x > 10)
        {
            transform.position += new Vector3(10, -3);
        }
    }

    public void OnCollisionEnter()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
