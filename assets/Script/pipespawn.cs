using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public float time = 1f;
    public float timer = 0f;
    public GameObject pipe;
    public float yuksekl�k;
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-yuksekl�k, yuksekl�k), 0);
    }


    void Update()
    {
        if (timer > time)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-yuksekl�k, yuksekl�k), 0);
            Destroy(newpipe, 10);  // 6 saniye sonra pipe'� yok edecek
            timer = 0;
        }
        timer += Time.deltaTime;
    }

}
