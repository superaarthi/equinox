using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {
    public Transform player;
    public Camera edgeCamera;
    public float xOffset;
    public float yOffset;

	// Update is called once per frame
	void Update () {
        bool xEdge = Mathf.Abs(player.position.x) < edgeCamera.orthographicSize * Screen.width / Screen.height - xOffset;
        bool yEdge = Mathf.Abs(player.position.y) < edgeCamera.orthographicSize - yOffset;
        if (xEdge && yEdge)
        {
            transform.position = new Vector3(player.position.x, player.position.y + 2.5f, -10);
        }
        else if(!xEdge && yEdge)
        {
            transform.position = new Vector3(transform.position.x, player.position.y + 2.5f, -10);
        }
        else if (xEdge && !yEdge)
        {
            transform.position = new Vector3(player.position.x, transform.position.y, -10);
        }
	}
}
