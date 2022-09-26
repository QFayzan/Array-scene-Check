using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public  RaycastHit hit;
    Vector3 rayDirection;

    bool stageHit = false;
    [SerializeField] Vector3 lastposition = Vector3.zero;

   
   void Start()
   {
    
   }
    // Update is called once per frame
    void Update()
    {
        //I need to divide raycast to each movement key
        //Raycast starts here
       // Correct one commented to implement direction stuff Ray myRay = new Ray(transform.position, new Vector3(0 , -1 , 1)); 
        Ray myRay = new Ray(transform.position, rayDirection); 
                if (Physics.Raycast(myRay, out hit, 1.5f))
                {
                    if (hit.collider.gameObject.tag == "Floor")
                    {
                        // COrrect one commentedDebug.DrawRay(transform.position, new Vector3(0, -1, 1), Color.blue);
                        Debug.DrawRay(transform.position, rayDirection, Color.blue);
                        stageHit = true;
                        Debug.Log(stageHit);
                    }
                }
                else
                {
                    stageHit = false;
                    Debug.Log(stageHit);
                }
        
        //Raycast ends here
        //Movement done and logged
        //Forward Input starts here
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            rayDirection = new Vector3(0 , -0.5f ,1);
            if (stageHit)
            {
                transform.Translate(Vector3.forward);
                lastposition = new Vector3(transform.position.x, 0, transform.position.z);
            }
        }
        //forward Input ends here
        //Back Input starts here
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rayDirection = new Vector3(0, -0.5f, -1);
            if (stageHit)
            {
                transform.Translate(Vector3.back);
                lastposition = new Vector3(transform.position.x, 0, transform.position.z);
            }
        }
        //Back Input ends here
        //Right Input starts here
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rayDirection = new Vector3(1, -0.5f, 0);
            if (stageHit)
            {
                transform.Translate(Vector3.right);
                lastposition = new Vector3(transform.position.x, 0, transform.position.z);
            }
        }
        //Right Input ends here
        //Left Input starts here

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rayDirection = new Vector3(-1, -0.5f, 0);
            if (stageHit)
            {
                transform.Translate(Vector3.left);
                lastposition = new Vector3(transform.position.x, 0, transform.position.z);
            }
        }
            
        
        //Movement Boundary code here
        if (transform.position.x < 0)
            {
                transform.position = new Vector3(0, transform.position.y, lastposition.z);
            }
        if (transform.position.z < 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            }
       
      //  if (transform.position.x > StageSpawner.S)
    }
}
