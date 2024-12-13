using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopspanel : MonoBehaviour
{
    public GameObject ShopUi;
    // Start is called before the first frame update
    void Start()
    {
        ShopUi.SetActive(false);
    }

    public void Turnonui() { ShopUi.SetActive(!ShopUi.activeSelf); }

    // Update is called once per frame
    void Update()
    {
        
    }
}
