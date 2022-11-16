using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(() => { SceneManager.LoadScene(sceneName); });
    }
}
