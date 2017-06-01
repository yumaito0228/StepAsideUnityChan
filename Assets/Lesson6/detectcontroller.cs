using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectcontroller : MonoBehaviour {

	public GameObject Unitychan;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = this.transform.position;
		pos.z = Unitychan.transform.position.z - 8;
		this.transform.position = pos;
	}
	void OnTriggerEnter(Collider other) {
		//障害物に衝突した場合
		if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag") {
			Destroy (other.gameObject);
		}
		//コインに衝突した場合
		if (other.gameObject.tag == "CoinTag") {
			//接触したコインのオブジェクトを破棄
			Destroy (other.gameObject);
		}
	}
}
