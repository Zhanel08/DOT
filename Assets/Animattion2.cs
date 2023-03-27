using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animattion2 : MonoBehaviour
{
    private Tween tween;
    void Start()
    {
        tween = transform.DOMove(new Vector3(15, 4, -8),2)
            .SetLoops(-1, LoopType.Yoyo);
    }

    void Update()
    {
        
    }
}
