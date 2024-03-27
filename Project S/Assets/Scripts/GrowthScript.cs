using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private bool inRange = false;
    public GameObject Player;
    public int growthRate = 0;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag == "Player")
        {
            Debug.Log("ENTERED RANGE");
            inRange = true;
        }
    }

    void Update() 
    {
        
        if (inRange)
        {
                Vector3 startPos = transform.Position;
                yield return new WaitForSeconds(1f);
                Vector3 finalPos = transform.Position;

                if( startPos.x != finalPos.x || startPos.y != finalPos.y
                    || startPos.z != finalPos.z)
                    {
                        Debug.Log("PLAYER IS CURRENTLY MOVING IN RANGE");
                    }
            Debug.Log("PLAYER IS IN RANGE BUT NOT MOVING");
        }
        Debug.Log("PLAYER IS NOT IN RANGE");
    }
}
