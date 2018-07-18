using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
            transform.position += 2 * Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;

    }
}
