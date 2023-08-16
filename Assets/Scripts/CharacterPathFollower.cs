using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPathFollower : MonoBehaviour
{
    public List<Transform> pathPoints;
    public int currentPointIndex = 0;
    public float moveSpeed = 5.0f;
    public Transform target;
    private void Update()
    {
        
        
        if (Input.GetKey(KeyCode.Space))
        {
            // Parmağımı bastığımda down, kaldırdığımda up
            if (currentPointIndex < pathPoints.Count)
            {
                
                Transform currentPoint = pathPoints[currentPointIndex];
                Vector3 targetPosition = currentPoint.position;
                Vector3 lookDirection = target.position - transform.position;
                lookDirection.y = 0;
                Quaternion rotation = Quaternion.LookRotation(lookDirection);
                transform.rotation = rotation;
                
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
                
                if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
                {
                    currentPointIndex++;
                }
            }
        }
    }
}
/*public class CharacterPathFollower : MonoBehaviour
{
    public List<Transform>  pathPoints;

    private int currentPointIndex = 0;
    
    public float moveSpeed = 5.0f;

    private int diziUzunlugu;

    private void Start()
    {
        //pathPoints = GameObject.Find("Path Point").GetComponentInChildren<Transform[]>(); //Hycary de performans açısından sıkıntı
        diziUzunlugu = pathPoints.Count;

    }
    // Break Point koy 
    
    void Update()
    {
        
        //Parmağımı bastığımda down, kaldırdığımda up
            
        Transform currentPoint = pathPoints[currentPointIndex];

        Vector3 targetPosition = currentPoint.position;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (transform.position == targetPosition && diziUzunlugu!=currentPointIndex+1)
        {
            currentPointIndex++;
        }
        // ben dizinin boyutunu nasıl tutarım ?
    }
}
}
*/