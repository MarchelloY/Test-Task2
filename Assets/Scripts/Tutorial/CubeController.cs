using DG.Tweening;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public void PlayCubeAnimation()
    {
        var targetPosition = transform.up * 3f;
        const float duration = 1f;
        var eulerAngels = new Vector3(0, 180f, 0);
        var sequence = DOTween.Sequence();
        
        sequence.Append(transform.DOMove(targetPosition, duration));
        sequence.Join(transform.DORotate(eulerAngels, duration));
        
        sequence.AppendInterval(0.5f);
        sequence.Append(transform.DOScale(Vector3.one * 0.75f, 0.3f));
        sequence.Append(transform.DOScale(Vector3.one * 1.5f, 1f));
        
        sequence.Join(transform.DORotate(eulerAngels, duration, RotateMode.LocalAxisAdd));
        sequence.Append(transform.DOScale(Vector3.one, 0.2f));
        
        sequence.OnComplete(OnComplete);
    }

    private void OnComplete()
    {
        Debug.Log("kek");
    }
}
