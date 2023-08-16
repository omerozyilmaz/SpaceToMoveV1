using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
 private Vector3 offSet = new Vector3(0,4,-10);
 public GameObject player;

 public void Update()
 {

  transform.position = player.transform.position + offSet;

 }
}
