using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Resizing : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Vector3 hoverScale = new Vector3(1.05f, 1.05f, 0); // ������ �������� ��� ��������� ������
    public float transitionDuration = 0.2f; // ������������ �������� ��������� �������

    private Vector3 initialScale; // �������� ������ ��������
    private bool isHovering; // ����, ����������� �� ��, ��������� �� ��������� ���� ��� ���������

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    private void Update()
    {
        // ���� ��������� ���� ��������� ��� ���������, ����������� ��� ������ � �������������� ��������
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
