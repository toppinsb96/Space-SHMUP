using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {
	public float rotationsPerSecond = 0.1f;
	public int levelShown = 0;

	void Start () {

	}
	void Update () {
		int currLevel = Mathf.FloorToInt( Hero.S.shieldLevel ); // 1
		if (levelShown != currLevel) {
			levelShown = currLevel;
			Material mat = this.GetComponent<Renderer>().material;

			mat.mainTextureOffset = new Vector2( 0.2f*levelShown, 0 ); // 2
		}

		float rZ = (rotationsPerSecond*Time.time*360) % 360f; // 3
		transform.rotation = Quaternion.Euler( 0, 0, rZ );
	}
}
