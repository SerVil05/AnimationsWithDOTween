using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Crocodile : MonoBehaviour
{

    [SerializeField] GameObject jaws;

    // Start is called before the first frame update
    void Start()
    {
        StartJawsAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartJawsAnimation() {
   
        Sequence mySequence = DOTween.Sequence();
        mySequence.SetLoops(-1);
        mySequence.Append(jaws.transform.DORotate(new Vector3(0.0f, -180.0f, 30.0f), 1.0f, RotateMode.Fast));
        mySequence.Append(jaws.transform.DORotate(new Vector3(0.0f, -180.0f, 0.0f), 1.0f, RotateMode.Fast));
    }
}
