using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingScriptText : MonoBehaviour
{

    [SerializeField] float speed;

    [SerializeField] int direction = 1;


    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(1 * direction * speed * Time.deltaTime, 0));


    }
}

