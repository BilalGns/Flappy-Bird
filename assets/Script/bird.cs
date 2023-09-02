using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    public float zıplama_aralıgı;
    public Text skortext;
    public float skor;
    Rigidbody2D rigidbody;
    public GameObject restartbutonu;
   

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();    
        restartbutonu.SetActive(false);
        skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
       

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //down olmazsa sol click veya space tu�una bas�l� kal�rsa ku� u�maya devam eder.
        {
            rigidbody.velocity = Vector2.up * zıplama_aralıgı;
        }

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                rigidbody.velocity = Vector2.up * zıplama_aralıgı;
            }

            
        }
        skortext.text = skor.ToString();
    }

     void OnTriggerEnter2D(Collider2D temas)
     {
        if (temas.gameObject.tag == "score")
        {
            Debug.Log("skor alan�na geldik");
            skor++; // score tag� olan obje ile temasa ge�ildi�inde skoru 1 artt�r

        }
     }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "pipe" || temas.gameObject.tag == "dead" )
        {
           
            restartbutonu.SetActive(true);
            Time.timeScale = 0; // time.scale çalışan herşeyi durdurur.
        }
    }

}
