using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UI;

namespace UI
{
	public class ScenesController : MonoBehaviour
	{

		public void LoadMainMenuScene()
		{
			SceneManager.LoadScene(Const.MainMenu);
		}

		public void LoadGameScene()
		{
			SceneManager.LoadScene(Const.Game);
		}

		public void LoadSettingScene()
		{
			SceneManager.LoadScene(Const.Settings);
		}

        public void CloseGame()
        {
            Application.Quit();
        }


	}
}

