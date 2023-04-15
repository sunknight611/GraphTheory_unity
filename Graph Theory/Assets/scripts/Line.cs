using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    //线段渲染器
    public LineRenderer lineRenderer1;
    public LineRenderer lineRenderer2;
    //设置线段的个数，标示一个线由几条线段组成
    private int lineLength = 4;

    //记录4个点，通过这4个点去连接一条线段
    private Vector3 v0 = new Vector3(2.0f, -2.0f, 0.0f);
    private Vector3 v1 = new Vector3(4.0f, -2.0f, 0.0f);
    private Vector3 v2 = new Vector3(6.0f, -2.0f, 0.0f);
    private Vector3 v3 = new Vector3(8.0f, -2.0f, 0.0f);

    public Vector3[] v5;

void Start()
{
    //设置线段长度，这个数值须要和绘制线3D点的数量想等
    //不设置会抛异常
    lineRenderer1.SetVertexCount(lineLength);//5.x版本添加线段长度 2018版本会显示已经过时

    lineRenderer2.positionCount = v5.Length;//2018版本添加线段长度



    //参数（要设置的位置数组）
    //参数是Vector3数组
    lineRenderer2.SetPositions(v5);


    //参数 （线段ID，位置）注意线段ID相同代表一个线段
    lineRenderer1.SetPosition(0, v0);
    lineRenderer1.SetPosition(1, v1);
    lineRenderer1.SetPosition(2, v2);
    lineRenderer1.SetPosition(3, v3);
  }
}
