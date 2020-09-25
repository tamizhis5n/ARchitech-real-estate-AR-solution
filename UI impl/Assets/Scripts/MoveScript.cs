using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [Range(0,20)]public float speed = 5.0f;
    public Canvas Popup = null;
    // Update is called once per frame

    void Start() {
        Popup.enabled = false;
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        transform.Translate(0,0,-horizontal * Time.deltaTime);
    }

    void OnTriggerStay(Collider other) {
        if (other.CompareTag("Trigger"))
        {
            Popup.enabled = true;
        }
    }

}
