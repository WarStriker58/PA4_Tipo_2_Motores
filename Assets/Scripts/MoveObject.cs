using UnityEngine;
using DG.Tweening;

public class MoveObject : MonoBehaviour
{
    public Vector3 targetPosition;

    public float duration;

    public void MoveToTarget()
    {
        transform.DOMove(targetPosition, duration).SetEase(Ease.Linear);
    }

    void Start()
    {
        MoveToTarget();
    }
}