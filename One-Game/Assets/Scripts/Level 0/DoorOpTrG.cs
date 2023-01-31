using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpTrG : MonoBehaviour
{
    float speed = 3f;
    bool MoveDoor = true;
    [SerializeField] public Collider2D cl;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (cl.transform.position.y > 23)
        {
            MoveDoor = false;
        }

        if (MoveDoor == true)
        {
            cl.transform.position = new Vector2(cl.transform.position.x, cl.transform.position.y + speed * Time.deltaTime);
        }
    }
}