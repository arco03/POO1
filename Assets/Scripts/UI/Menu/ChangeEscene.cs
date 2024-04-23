using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.Menu
{
    public class ChangeEscene : MonoBehaviour
    {
        public void Change(string name)
        {
            SceneManager.LoadScene(name);
        }
        public void Exit()
        {
            Application.Quit();
            Debug.Log("Saliste del Juego");
        }

    }
}