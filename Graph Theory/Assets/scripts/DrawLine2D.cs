using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine2D : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Color startColor;
    public Color endColor;

    public float startWidth;
    public float endWidth;
    public Vector3 startPosition;
    public Vector3 endPosition;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startColor = startColor;
        lineRenderer.endColor = endColor;
        lineRenderer.startWidth = startWidth;
        lineRenderer.endWidth = endWidth;

        int lengthY = (int)Math.Abs(endPosition.y - startPosition.y);
        int lengthX = (int)Math.Abs(endPosition.x - startPosition.x);
        float zPosition = Math.Max(startPosition.z, endPosition.z);
        Vector3 bottomPosition = startPosition.y < endPosition.y ? startPosition : endPosition;
        Vector3 leftPosition = startPosition.x < endPosition.x ? startPosition : endPosition;

        if (lengthY > lengthX && lengthY >= 1f)
        {
            lineRenderer.positionCount = lengthY;
            for (int i = 0; i < lengthY; ++i)
            {
                float xOffset = i * lengthX / lengthY;
                lineRenderer.SetPosition(i, new Vector3(leftPosition.x + xOffset, bottomPosition.y + (float)i, zPosition));
                Debug.Log(lineRenderer.transform.position.x);
            }
        }
        else if (lengthX >= 1f)
        {
            lineRenderer.positionCount = lengthX;
            for (int i = 0; i < lengthX; ++i)
            {
                float yOffset = i * lengthX / lengthY;
                lineRenderer.SetPosition(i, new Vector3(leftPosition.x + (float)i, bottomPosition.y + yOffset, zPosition));
            }
        }
    }
}
