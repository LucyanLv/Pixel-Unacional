using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    Canvas pauseDontDestroy;
    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(pauseDontDestroy);
    }
}
