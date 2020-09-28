using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{

    public float flySpeed = 24f;

    private Rigidbody2D pinBody;

    private bool shouldFly;
    // Start is called before the first frame update
    void Start()
    {
        shouldFly = true;
        pinBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldFly == true)
        {
            //make our pin fly
            pinBody.MovePosition(pinBody.position + Vector2.up * flySpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "magenta")
        {
        shouldFly = false;
        Destroy(gameObject);
        }
        else if(collision.tag == "purple" || collision.tag == "yello")
        {
            SceneManager.LoadScene("GameOverScene");
        }
       
    }
}
