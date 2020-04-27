using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCamera;
    [SerializeField]
    private GameObject subCamera;
    

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.SetActive(false);
        subCamera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Startbutton()
    {
        SceneManager.LoadScene("Scene");
    }

    public void Endbutton()
    {
        Application.Quit();
    }

    public void SwitchCamera()
    {
        mainCamera.SetActive(!mainCamera.activeSelf);
        subCamera.SetActive(!subCamera.activeSelf);
    }
}
