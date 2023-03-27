using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animation3 : MonoBehaviour
{
    public Material _mat; 

    void Start()
    {
        _mat.DOColor(Color.cyan, "_Color", -2);
    }

    // Update is called once per frame
    void Update()
    {
        Sequence transformCube = DOTween.Sequence();
        transformCube.Append(transform.DOMoveX(15, 1))
            .Append(transform.DOMove(new Vector3(15, 4, -8), 2))
            .Append(transform.DORotate(new Vector3(0, 180, 0), 5))
            .Insert(0, transform.DOScale(new Vector3(3, 3, 3), transformCube.Duration()));

        _mat.DOColor(Color.red, "_Color", 5);
    }
    private void OnMouseDown()
    {
        DOTween.RestartAll();
    }
}
