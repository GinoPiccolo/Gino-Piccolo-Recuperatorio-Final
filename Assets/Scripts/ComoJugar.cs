using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComoJugar : MonoBehaviour
{
	public Button yourButton2;

	void Start()
	{
		Button btnn = yourButton2.GetComponent<Button>();
		btnn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(5);
	}
}
