using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Experimental.Animations;
// include line 4 if using TMP

public class MustardBottle : MonoBehaviour
{
    public TMP_Text mustardText;
    public Animator IdolAnimation;
    //if not using TMP, make line 8 public Text mustard;
    private int MustardCounter;
    // start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Addmustard()
    {
        Animator.Play(IdolAnimation);
        MustardCounter++;
        mustardText.text = "MUSTARD: " + MustardCounter;
    }
}
