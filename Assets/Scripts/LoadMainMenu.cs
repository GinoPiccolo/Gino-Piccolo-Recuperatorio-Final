using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadMainMenu : MonoBehaviour
{	public Button yourButton;

	void Start() {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Grounded.nivel = 0;
		SceneManager.LoadScene(0);
		Cursor.lockState = CursorLockMode.None;
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
	}
}
