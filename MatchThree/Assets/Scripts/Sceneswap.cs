using UnityEngine;
using UnityEngine.SceneManagement;
public class Sceneswap : MonoBehaviour
{
    public void Scene0()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Scene1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("About");
    }
}