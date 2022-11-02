using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrigerRestart : MonoBehaviour
{
    [SerializeField] private GameObject gameEnd;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            SceneManager.LoadScene(0);
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("Ending"))
        {
            gameEnd.SetActive(true);
        }
    }
}
