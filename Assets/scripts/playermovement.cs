using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
 
   
 /*   private void Start()
    {
        // save the horizontal center of the screen
        
    }
 
    private void Update()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // if there are any touches currently
        if(Input.touchCount > 0)
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);
            Vector3 touch_pos = Camera.main.ScreenToWorldPoint(firstTouch.position);
            
                if(touch_pos.x < 0)
                {
                    // if the touch position is to the right of center
                    // move right
                    //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    Debug.Log("right");
                }
                else if(touch_pos.x > 0)
                {
                    // if the touch position is to the left of center
                    // move left
                    //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    Debug.Log("left");
                }
            
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}

*/



















// Start is called before the first frame update
    void Start()
    {
        
    }

void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_pos = Camera.main.ScreenToWorldPoint(touch.position);
            
            if (touch_pos.x > 0)
            {
                 rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                 Debug.Log("right");
            }
            else if(touch_pos.x < 0)
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("left");
            }
            if (rb.position.y < -1f)
           {
            FindObjectOfType<gamemanager>().EndGame();
           }
        }
    }
}







     /*Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }

    }
}*/
