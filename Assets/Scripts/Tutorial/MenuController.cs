using DG.Tweening;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    [SerializeField] private Transform centerPoint;
    [SerializeField] private Transform panelPause;
    [SerializeField] private Transform playButton;

    private float _pausePanelStartY;
    private bool _isPause;
    
    // Start is called before the first frame update
    private void Start()
    {
        _pausePanelStartY = panelPause.position.y;
        panelPause.localScale = Vector3.zero;
    }

    // Update is called once per frame
    public void ShowPauseMenu()
    {
        var positionY = _isPause ? _pausePanelStartY : centerPoint.position.y;
        panelPause.DOMoveY(positionY, 1f);
        var scale = _isPause ? Vector3.zero : Vector3.one;
        panelPause.DOScale(scale, 1f);

        if (_isPause)
        {
            var sequence = DOTween.Sequence();
            sequence.Append(playButton.DOScale(Vector3.one, 0.5f));
            sequence.Append(playButton.DOShakeRotation(
                0.3f, new Vector3(0, 0, 30f), 20, 100));
        }
        else
        {
            playButton.DOScale(Vector3.zero, 0.5f);
        }

        _isPause = !_isPause;
    }
}
