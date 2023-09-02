using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public float time = 1f;
    public float timer = 0f;
    public GameObject pipe;
    public float yukseklýk;
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-yukseklýk, yukseklýk), 0);
    }


    void Update()
    {
        if (timer > time)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-yukseklýk, yukseklýk), 0);
            Destroy(newpipe, 10);  // 6 saniye sonra pipe'ý yok edecek
            timer = 0;
        }
        timer += Time.deltaTime;
    }

}
