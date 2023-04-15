using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    //�߶���Ⱦ��
    public LineRenderer lineRenderer1;
    public LineRenderer lineRenderer2;
    //�����߶εĸ�������ʾһ�����ɼ����߶����
    private int lineLength = 4;

    //��¼4���㣬ͨ����4����ȥ����һ���߶�
    private Vector3 v0 = new Vector3(2.0f, -2.0f, 0.0f);
    private Vector3 v1 = new Vector3(4.0f, -2.0f, 0.0f);
    private Vector3 v2 = new Vector3(6.0f, -2.0f, 0.0f);
    private Vector3 v3 = new Vector3(8.0f, -2.0f, 0.0f);

    public Vector3[] v5;

void Start()
{
    //�����߶γ��ȣ������ֵ��Ҫ�ͻ�����3D����������
    //�����û����쳣
    lineRenderer1.SetVertexCount(lineLength);//5.x�汾����߶γ��� 2018�汾����ʾ�Ѿ���ʱ

    lineRenderer2.positionCount = v5.Length;//2018�汾����߶γ���



    //������Ҫ���õ�λ�����飩
    //������Vector3����
    lineRenderer2.SetPositions(v5);


    //���� ���߶�ID��λ�ã�ע���߶�ID��ͬ����һ���߶�
    lineRenderer1.SetPosition(0, v0);
    lineRenderer1.SetPosition(1, v1);
    lineRenderer1.SetPosition(2, v2);
    lineRenderer1.SetPosition(3, v3);
  }
}
