using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Rope : MonoBehaviour
{
    [SerializeField] Transform ropeTransform;

    // Start is called before the first frame update
    void Start()
    {
        PlayRopeAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayRopeAnimation() 
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.SetLoops(-1);
        mySequence.Append(ropeTransform.transform.DOMove(new Vector3(0.0f, 6.0f, 0.0f), 1.0f));
        mySequence.Append(ropeTransform.transform.DOMove(new Vector3(0.0f, 10.5f, 0.0f), 1.0f));
    }
}
