using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowMe : MonoBehaviour
{
   public GameObject Player;
    
   public Vector3 player = new Vector3(0, 0, 0);
   public Vector3 offset = new Vector3(0, 2, 0);
   public Vector3 offsetArnold = new Vector3(0, 8, 0);
    public bool arnold = false;
    public Quaternion angleOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
        transform.rotation = Player.transform.rotation * angleOffset;
        if (Input.GetKeyDown(KeyCode.J))
        {
            arnold= true;
        }
        if (Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.P))
        {
            arnold= false;
        }
        if(arnold)
        {
            transform.position = Player.transform.position + offsetArnold;       
        }
        else
        {
            transform.position = Player.transform.position + offset;
        }
           
    }
}
