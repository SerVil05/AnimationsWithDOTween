using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Crab : MonoBehaviour
{

    [SerializeField] Transform crabTransform;

    // Start is called before the first frame update
    void Start()
    {
        PlayCrabAnimation();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayCrabAnimation()
    {
 
        Sequence mySequence = DOTween.Sequence();
        mySequence.SetLoops(-1);
        mySequence.Append(crabTransform.transform.DOMove(new Vector3(8.0f, -2.5f, 0.0f), 3.0f));
        mySequence.Append(crabTransform.transform.DOMove(new Vector3(6.5f, -2.5f, 0.0f), 3.0f));
              
    }
}
