using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSprite : MonoBehaviour
{
    public Image unityImage;
    public Image heartImage;
    public Image coffeeImage;
    
    public float duration = 0.5f;
    public AnimationCurve unityAnimationCurve;
    public AnimationCurve heartAnimationCurve;
    public AnimationCurve coffeeAnimationCurve;
    
    [Method]
    void UpdateUnityValue(float unityImageValue)
    {
        unityImage.DOFillAmount(unityImageValue, duration)
            .SetEase(unityAnimationCurve)
            .OnStart(() => Debug.Log("Unity Image Start"))
            .OnComplete(() => Debug.Log("Unity Image Complete"))
            .OnUpdate(() => Debug.Log("Unity Image Update"));
    }
    
    [Method]
    void UpdateHeartValue(float heartImageValue)
    {
        heartImage.DOFillAmount(heartImageValue, duration)
            .SetEase(heartAnimationCurve)
            .OnStart(() => Debug.Log("Heart Image Start"))
            .OnComplete(() => Debug.Log("Heart Image Complete"))
            .OnUpdate(() => Debug.Log("Heart Image Update"));
    }
    
    [Method]
    void UpdateCoffeeValue(float coffeeImageValue)
    {
        coffeeImage.DOFillAmount(coffeeImageValue, duration)
            .SetEase(coffeeAnimationCurve)
            .OnStart(() => Debug.Log("Coffee Image Start"))
            .OnComplete(() => Debug.Log("Coffee Image Complete"))
            .OnUpdate(() => Debug.Log("Coffee Image Update"));
    }
}