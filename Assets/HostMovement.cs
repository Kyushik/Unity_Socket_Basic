using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using SocketIO;

public class HostMovement : MonoBehaviour {
	public int action { get; set; }

	// Use this for initialization
	private IEnumerator Start() 
	{
		//DontDestroyOnLoad(this.gameObject);
		yield return new WaitForSeconds(0.5f);
		CommandServer.Instance.Init();
		CommandServer.Instance.EmitTelemetry ();

	}

	// Update is called once per frame
	private void Update() 
	{
		if (action == 1) {
			print ("Connected!!");
		}
	}
}

