using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Begin : MonoBehaviour
{

    public GameObject myObj;
    public Transform myObjPos;

    static Begin() {
        EditorApplication.update += Update;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    static void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Debug.Log("Test");
        }

        if (Input.GetKeyDown("a")) {
            Debug.Log("Testh");
        }
    }
}
