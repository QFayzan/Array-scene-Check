using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
     StageSpawner Length;
    [SerializeField] Vector3 lastposition = Vector3.zero;
   
   void Start()
   {
    
   }
    // Update is called once per frame
    void Update()
    {
        //Movement done and logged
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward);
            lastposition = new Vector3 (transform.position.x , 0 , transform.position.z);
        } 
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back);
            lastposition = new Vector3 (transform.position.x , 0 , transform.position.z);
        } 
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right);
            lastposition = new Vector3 (transform.position.x , 0 , transform.position.z);
        } 
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left);
            lastposition = new Vector3 (transform.position.x , 0 , transform.position.z);
        } 
        //Movement Boundary code here
        if (transform.position.x <0 )
        {
            transform.position = new Vector3 (0 , transform.position.y , lastposition.z);
        }
      //  if (transform.position.x > StageSpawner.S)
    }
}
