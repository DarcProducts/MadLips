using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static void LoadLevel(int level) => SceneManager.LoadScene(level);

    public static void LoadLevel(string level) => SceneManager.LoadScene(level);
}
