using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    public void getAnimatorDefalt(){
        this.GetComponent<Animator>().Play("Dancing");
    }

    public void getAnimatorWalk(){
        this.GetComponent<Animator>().Play("Walking");
    }
}
