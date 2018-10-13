using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class StartUpScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		EnemyController.paths = JsonConvert.DeserializeObject<List<Dictionary<string, List<List<int>>>>>(File.ReadAllText(@"Assets/Scripts/paths.json"));
		Debug.Log(EnemyController.paths[0]["0_0"][0][0]);
		Debug.Log(EnemyController.paths[0]["0_0"][0][1]);
		Debug.Log(EnemyController.paths[0]["0_0"][1][0]);
		Debug.Log(EnemyController.paths[0]["0_0"][1][1]);
	}

	// Update is called once per frame
	void Update () {

	}
}
