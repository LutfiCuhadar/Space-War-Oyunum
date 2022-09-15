using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerMenuScene : MonoBehaviour
{
    public GameObject MenuScreen;
    public GameObject dataBoard;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void PlayButton() 
    {
        SceneManager.LoadScene(1); 
    }

    public void ExitButton()
    {
        MenuScreen.SetActive(false);
    }

    public void DataBoardButton()
    {
        DataManager.Instance.LoadData();

        dataBoard.transform.GetChild(1).GetComponent<Text>().text = "Total Bullet Shot : " + DataManager.Instance.totalShotBullet.ToString();
        dataBoard.transform.GetChild(2).GetComponent<Text>().text = "Total Enemy Shot : " + DataManager.Instance.totalEnemyKilled.ToString();
        dataBoard.SetActive(true);
    }

    public void XButton()
    {
        dataBoard.SetActive(false);
    }
}
