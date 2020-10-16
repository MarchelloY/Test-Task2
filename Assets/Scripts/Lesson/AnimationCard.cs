using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AnimationCard : MonoBehaviour
{
    [SerializeField] private Transform card;
    [SerializeField] private Button playButton;
    [SerializeField] private Transform[] points;
    
    private Tweener _tweener;

    private void Start()
    {
        playButton.onClick.AddListener(Play);
    }

    private void Play()
    {
        var path = new Vector3[points.Length];
        for (var i = 0; i < points.Length; i++)
        {
            path[i] = points[i].position;
        }
        var sequence = DOTween.Sequence();
        sequence.AppendInterval(1.5f);
        sequence.Append(card.DOScale(Vector3.one * 1.5f, 1.5f));
        sequence.Append(card.DOShakeRotation(
            1f, new Vector3(0, 0, 30f), 10, 40));
        card.DOPath(path, 3f);
    }
}
