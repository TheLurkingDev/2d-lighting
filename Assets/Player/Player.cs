using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _transform;
    
    // Start is called before the first frame update
    void Start()
    {
        _transform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                _transform.Translate(Vector3.up);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _transform.Translate(Vector3.down);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _transform.Translate(Vector3.left);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _transform.Translate(Vector3.right);
            }
        }
    }
}
