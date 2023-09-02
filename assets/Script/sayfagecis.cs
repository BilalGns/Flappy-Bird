using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sayfagecis : MonoBehaviour
{
    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Baþlangýcsayfasý()
    {
        SceneManager.LoadScene("Baþlangýcsayfasý");
    }
        

    public void smaplescene2()
    {
        SceneManager.LoadScene("Samplescene");
        Time.timeScale = 1;
    }

}
