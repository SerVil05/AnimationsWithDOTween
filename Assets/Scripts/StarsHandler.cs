using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StarsHandler : MonoBehaviour
{
    [SerializeField] SpriteRenderer[] Stars;
    private const int FALLING_STAR_INDEX = 4;

    private Vector3 FALLING_STAR_DEFAULT_POSITION = new Vector3(-5.0f, 7.0f);
    private Vector3 FALLING_STAR_FINISH_POSITION = new Vector3(10.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        PlayFallingStarAnimation();
        PlayFlashingStarsAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayFlashingStarsAnimation() {

        Sequence flashingStarsSequence = DOTween.Sequence();
        flashingStarsSequence.SetLoops(-1);
        flashingStarsSequence.Append(Stars[0].transform.DOScale(0.5f, 1.0f));
        flashingStarsSequence.Join(Stars[1].transform.DOScale(0.5f, 1.0f));
        flashingStarsSequence.Join(Stars[2].transform.DOScale(0.75f, 1.0f));
        flashingStarsSequence.Join(Stars[3].transform.DOScale(0.25f, 1.0f));

        flashingStarsSequence.Append(Stars[0].transform.DOScale(1.0f, 1.0f));
        flashingStarsSequence.Join(Stars[1].transform.DOScale(0.25f, 1.0f));
        flashingStarsSequence.Join(Stars[2].transform.DOScale(1.25f, 1.0f));
        flashingStarsSequence.Join(Stars[3].transform.DOScale(0.75f, 1.0f));

    }

    void PlayFallingStarAnimation() {
        Sequence fallingStarSequence = DOTween.Sequence();
        fallingStarSequence.SetLoops(-1);
        fallingStarSequence.Append(Stars[FALLING_STAR_INDEX].transform.DOMove(FALLING_STAR_FINISH_POSITION, 2.0f));
        fallingStarSequence.Join(Stars[FALLING_STAR_INDEX].DOFade(0.0f, 2.0f));
        fallingStarSequence.OnComplete(ResetFallingStarPositionAndAlpha);
        
    }

    void ResetFallingStarPositionAndAlpha()
    {
        Stars[FALLING_STAR_INDEX].transform.position = FALLING_STAR_DEFAULT_POSITION;
        Stars[FALLING_STAR_INDEX].DOFade(1.0f, 0.1f);
    }
}
