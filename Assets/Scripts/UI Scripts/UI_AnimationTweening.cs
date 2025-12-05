using UnityEngine;
using System.Collections.Generic;


public class UI_AnimationTweening : MonoBehaviour
{
   public CanvasGroup cg;

void Start()
{
    cg.alpha = 1f;
    cg.interactable = true;
    cg.blocksRaycasts = true;
    cg.ignoreParentGroups = false;
}
}
