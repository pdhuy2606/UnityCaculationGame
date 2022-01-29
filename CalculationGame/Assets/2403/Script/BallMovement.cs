using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rig;
    Transform trans;
    void Start()
    {
        trans = GetComponent<Transform>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        ControlDirection();
    }

    public void ControlDirection()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 temptVect = new Vector3(horizontal, vertical, 0);
        temptVect = temptVect.normalized * speed * Time.deltaTime;
        rig.MovePosition(rig.transform.position + temptVect);
        //rig.AddForce(new Vector2(horizontal, vertical) * speed * Time.deltaTime, ForceMode.Force);

      
       // rig.AddForce(new Vector2(horizontal,vertical) * speed * Time.deltaTime);
    }
}
