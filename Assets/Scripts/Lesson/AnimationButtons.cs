using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AnimationButtons : MonoBehaviour
{
    [SerializeField] private Button shopButton;
    [SerializeField] private Button plusButton;

    [SerializeField] private float duration = 1f;
    
    private void Start()
    {
        shopButton.onClick.AddListener(ClickShopButton);
        plusButton.onClick.AddListener(ClickPlusButton);
    }

    private void ClickPlusButton()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(plusButton.transform.DOScale(Vector3.one * 0.5f, duration));
        sequence.Join(plusButton.transform.DORotate(new Vector3(0, 180f, 0), duration));
    }

    private void ClickShopButton()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(shopButton.transform.DOShakeRotation(
            duration, new Vector3(0, 0, 30f), 20, 100));
        sequence.Append(shopButton.transform.DOScale(Vector3.one * 1.5f, duration));
    }
}
