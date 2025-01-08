using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SD.Examples{
	public class FinishRotate : MonoBehaviour {


	// Use this for initialization
	void Update () {
		transform.Rotate (0, 1, 0, Space.World);
		}
 }
}


