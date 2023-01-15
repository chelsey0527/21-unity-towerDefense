using UnityEngine;

public class CameraEditorControl : MonoBehaviour
{
// 這是讓腳本只在 "Unity編輯器" 內才有作用的方式
#if UNITY_EDITOR
	public float speed = 5f;

	//偵測滑鼠移動反映到畫面
	void Update()
	{
		float horizontal = Input.GetAxis("Mouse X") * speed;
		float vertical = Input.GetAxis("Mouse Y") * speed;

		transform.Rotate(0f, horizontal, 0f, Space.World);
		transform.Rotate(-vertical, 0f, 0f, Space.Self);
	}
#endif
// 記得加上結束
}
