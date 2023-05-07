using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject level;

    public void NextScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void PremadeLevelOn()
    {
        level.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void ReturnToRegularLevel()
    {
        level.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
