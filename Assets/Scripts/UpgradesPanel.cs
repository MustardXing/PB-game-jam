using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject UpgradeUi;

    // Start is called before the first frame update
    void Start()
    {
        UpgradeUi.SetActive(false);
    }
    public void Turnonui() { UpgradeUi.SetActive(!UpgradeUi.activeSelf);}
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
