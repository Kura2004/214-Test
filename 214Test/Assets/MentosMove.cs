using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentosMove : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Delicious");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime);

    }
}
