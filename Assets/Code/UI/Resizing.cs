using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Resizing : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Vector3 hoverScale = new Vector3(1.05f, 1.05f, 0); // Размер элемента при наведении мышкой
    public float transitionDuration = 0.2f; // Длительность анимации изменения размера

    private Vector3 initialScale; // Исходный размер элемента
    private bool isHovering; // Флаг, указывающий на то, находится ли указатель мыши над элементом

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    private void Update()
    {
        // Если указатель мыши находится над элементом, увеличиваем его размер с использованием анимации
        if (isHovering)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, hoverScale, Time.deltaTime / transitionDuration);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, initialScale, Time.deltaTime / transitionDuration);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovering = false;
    }
}
