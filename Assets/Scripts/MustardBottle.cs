using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Experimental.Animations;
// include line 4 if using TMP

public class MustardBottle : MonoBehaviour
{
    public TMP_Text mustardText;
    public Animator animator;
    //if not using TMP, make line 8 public Text mustard;
    public int MustardCounter;
    public int Multiplier = 1;
    public int multiplierCost;
    // start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mustardText.text = "MUSTARD: " + MustardCounter;

    }

    public void Addmustard()
    {
        animator.Play("clickAnimation");
        MustardCounter += 1 * Multiplier ;

    }

    public void ClickMultiplier()
    {
        MustardCounter -= multiplierCost;
        multiplierCost = multiplierCost * 2;
        Multiplier += 1;
    }
}
