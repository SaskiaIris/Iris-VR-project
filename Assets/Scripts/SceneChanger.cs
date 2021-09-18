using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
	public void changeScene(int sceneNumber) {
		SceneManager.LoadScene(sceneNumber);
	}

	public void exitGame() {
		Application.Quit();
	}
}