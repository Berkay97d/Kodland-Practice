using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(RestartGame);
    }

    private void RestartGame()
    {
        Bullet.ResetKilledEnemyCount();
        SceneManager.LoadScene(0);
    }
}
