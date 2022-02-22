using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoNext : MonoBehaviour
{
	public Button yourButton;
	public Texture2D cursorArrow;
	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{		
		SceneManager.LoadScene(Grounded.nivel + 1);
		Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
		Cursor.lockState = CursorLockMode.Confined;
	}
}
