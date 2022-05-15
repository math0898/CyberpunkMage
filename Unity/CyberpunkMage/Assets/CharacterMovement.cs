using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    /**
     * The Rigidbody attached to this character.
     */
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("A is being pressed");
            rb.velocity = rb.velocity + new Vector2(-10, 0);
        } else if (Input.GetKeyUp(KeyCode.A)) {
            Debug.Log("A has been released");
            rb.velocity = rb.velocity + new Vector2(10, 0);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            Debug.Log("D is being pressed");
            rb.velocity = rb.velocity + new Vector2(10, 0);
        } else if (Input.GetKeyUp(KeyCode.D)) {
            Debug.Log("D has been released");
            rb.velocity = rb.velocity + new Vector2(-10, 0);
        }
    }
}
