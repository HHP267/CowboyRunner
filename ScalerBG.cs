using UnityEngine;
using System.Collections;

public class ScalerBG : MonoBehaviour {

	void Start () {
		var height = Camera.main.orthographicSize * 2f;
		var width = height * Screen.width / Screen.height + 2f;

        if (gameObject.name == "Background")
        {
            transform.localScale = new Vector3(width, height, 0);
        }
        else
        {
            transform.localScale = new Vector3(width + 3f, 6, 0);
        }
	}

    void Update()
    {

    }
}
