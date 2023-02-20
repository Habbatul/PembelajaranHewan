using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   


 //====================================================================
    public void Object_InActive()
    {
        this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void Tombol_Mulai()
    {
        Destroy(GameObject.Find("Yulgar_Oyeeah"));
        SceneManager.LoadScene("Game");
    }
    public void Main_Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void pembuat()
    {
        SceneManager.LoadScene("Pembuat");
    }
    public void Detail()
    {
        SceneManager.LoadScene("Detail");
    }
    // Update is called once per frame
    public void Keluar()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }
}
