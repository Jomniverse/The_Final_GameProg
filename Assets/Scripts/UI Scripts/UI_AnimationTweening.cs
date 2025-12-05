using UnityEngine;
using System.Collections.Generic;
using DG.Tweening;


public class UI_AnimationTweening : MonoBehaviour
{
    public float fadeTime = 1f;
    public CanvasGroup canvasGroup;
    public RectTransform rectTransform;

public void PanelFadeIn()
{
    canvasGroup.alpha = 0f;
    rectTransform.anchoredPosition = new Vector2(0, 244);

    canvasGroup.DOFade(1f, fadeTime);
    rectTransform.DOAnchorPos(Vector2.zero, fadeTime)
                 .SetEase(Ease.OutBack);
}

public void PanelFadeOut()
{
    canvasGroup.alpha = 1f;

    canvasGroup.DOFade(0f, fadeTime);
    rectTransform.DOAnchorPos(new Vector2(0, 500), fadeTime)
                 .SetEase(Ease.InBack);
}

}
