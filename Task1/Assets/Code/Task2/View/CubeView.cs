using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeView : MonoBehaviour, IPointerClickHandler
{
    public Action Click;
    [SerializeField] private Material _cubeMaterial;

    public Material CubeMaterial => _cubeMaterial;

    public void OnPointerClick(PointerEventData eventData)
    {
        Click?.Invoke();
    }
}
