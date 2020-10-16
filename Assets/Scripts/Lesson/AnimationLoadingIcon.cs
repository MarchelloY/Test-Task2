using DG.Tweening;
using UnityEngine;

public class AnimationLoadingIcon : MonoBehaviour
{
    [SerializeField] private Transform loadingIcon1;
    [SerializeField] private Transform loadingIcon2;
    [SerializeField] private Transform loadingIcon3;
    
    [SerializeField] private float duration = 1f;
    
    private void Start()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(loadingIcon1.DORotate(new Vector3(0, 0, 180f), duration));
        sequence.Append(loadingIcon1.DORotate(new Vector3(0, 0, 0f), duration));
        sequence.AppendInterval(0.5f);
        sequence.Append(loadingIcon2.DORotate(new Vector3(0, 0, -180f), duration));
        sequence.Join(loadingIcon2.DOScale(Vector3.one * 2f, duration));
        sequence.AppendInterval(0.5f);
        sequence.Append(loadingIcon3.DORotate(new Vector3(0, 0, 180f), duration));
        sequence.Append(loadingIcon3.DOShakeRotation(
            duration, new Vector3(0, 0, 30f), 10, 40));
    }
}
