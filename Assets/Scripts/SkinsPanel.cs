using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsPanel : MonoBehaviour
{
    public GameObject SkinsUi;

    // Start is called before the first frame update
    void Start()
    {
        SkinsUi.SetActive(false);
    }
    public void Turnonui() { SkinsUi.SetActive(!SkinsUi.activeSelf); }
    // Update is called once per frame
    void Update()
    {
        
    }
}
