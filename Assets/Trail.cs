using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(EdgeCollider2D))]
public class Trail : MonoBehaviour {

    public float pointSpacing = .1f;

    LineRenderer lr;
    EdgeCollider2D ec;
    List<Vector2> points;
    public Transform head;
	// Use this for initialization
	void Start () {
        lr = GetComponent<LineRenderer>();
        ec = GetComponent<EdgeCollider2D>();
        points = new List<Vector2>();
        SetPoint();
	}
	
	// Update is called once per frame
	void Update () {

        if(Vector3.Distance(points.Last(),head.position) > pointSpacing){
            SetPoint();
        }
		
	}

    void SetPoint(){
        if (points.Count > 1)
        {
            ec.points = points.ToArray<Vector2>();
        }
        points.Add(head.position);
        lr.positionCount = points.Count;
        lr.SetPosition(points.Count - 1, head.position);
    }
}
