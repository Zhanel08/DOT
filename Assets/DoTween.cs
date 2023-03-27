using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DoTween : MonoBehaviour
{
    [SerializeField] float Delay = 1f;
    [SerializeField] Transform Target;

    private void Start()
    {
        transform.DOMoveX(-15, 1);
    }
    private void Update()
    {
        DOTweenSequence();
    }
    private void DOTweenSequence()
    {
        Sequence LeftSequence = DOTween.Sequence();
        LeftSequence.Append(transform.DOMoveX(15, 1)) // двигает до указанной позиции
          .Append(transform.DORotate(new Vector3(0, 180, 0), 1)) // поворачивает 
          .PrependInterval(1) //Добавляет заданный интервал к началу последовательности
          .Insert(0, transform.DOScale(new Vector3(3, 3, 3), LeftSequence.Duration())); // Вставляет данную анимацию движения в заданную временную позицию
        Sequence DownSequence = DOTween.Sequence();
        DownSequence.Append(transform.DOMoveZ(-8, 5))
            .Append(transform.DORotate(new Vector3(0, -180, 0), 1))
            .PrependInterval(1)
            
            .Insert(0, transform.DOScale(new Vector3(3, 3, 3), DownSequence.Duration()));
         
    }
    
}
