using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStart : MonoBehaviour
{
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {
        transition.SetTrigger("CircleOut");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
