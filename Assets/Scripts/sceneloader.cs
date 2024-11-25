using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENELOADER : MonoBehaviour
{
    public string nextlevel = "something";

    public void StartButton()
    {
        SceneManager.LoadScene(nextlevel);
    }
}
