using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplierButton : MonoBehaviour
{
    public Button ButtonClick;
    public MustardBottle MustardBottle;
    // Start is called before the first frame update
    void Start()
    {
        ButtonClick = GetComponent<Button>();
        MustardBottle = GetComponentInParent<MustardBottle>();
    }

    // Update is called once per frame
    void Update()
    {
        ButtonClick.interactable = (MustardBottle.MustardCounter > MustardBottle.multiplierCost);
    }
}
