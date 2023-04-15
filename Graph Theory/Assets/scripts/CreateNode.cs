using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNode : MonoBehaviour
{
    public GameObject[] obj;
    private Transform m_transform;
    private float m_hitz;
    public int[] input;
    private LineRenderer[] lineRenderArray;

    private LineRenderer lineRenderer;
    //定义一个Vector3,用来存储鼠标点击的位置
    private Vector3 position;
    //用来索引线条数
    private int index = 0;
    //端点数
    private int LengthOfLineRenderer = 0;
    public GameObject obj1;
    public int maxLine = 8;
    private bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i < 5; i++)
        {
           obj[i] = Instantiate(Resources.Load("Node"))as GameObject;
           //GetComponent<SpriteRenderer>().sprite = Resources.Load("h0")as Sprite;
           obj[i].transform.position = new Vector3(2.0f + 2.0f * i, -2.0f, 0f);
        }

        lineRenderArray = new LineRenderer[10];


    }

    // Update is called once per frame
    void Update()
    {
        MouseFollow();
    }

    void MouseFollow()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitinfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hitinfo))
            {
                if (hitinfo.transform.CompareTag("Node"))
                {
                    m_transform = hitinfo.transform;
                    m_hitz = Camera.main.WorldToScreenPoint(hitinfo.transform.position).z;
                }
            }
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 newPos = Camera.main.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_hitz));
            
        }

    }


    void dijkstra()
    {

    }

    void DrawRenderLine(LineRenderer line, Vector3 vect3)
    {
        Vector3 newPos = vect3;
        LengthOfLineRenderer++;
        line.positionCount = LengthOfLineRenderer;

        line.SetPosition(LengthOfLineRenderer - 1, newPos);
        if (line.positionCount == 2)
        {
            index++;
            if (index >= maxLine) index = 0;
            flag = true;
        }
        print("new point: " + newPos);

    }
    
}
