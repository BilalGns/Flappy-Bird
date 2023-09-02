using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singletonmuzik : MonoBehaviour
{
    private static Singletonmuzik obje = null;

    private void Awake()
    {
        if (obje==null)
        {
            obje = this;
            DontDestroyOnLoad(this);
        }
       
        else if(obje != null)
        {
            Destroy(gameObject);
        }
    }

}
