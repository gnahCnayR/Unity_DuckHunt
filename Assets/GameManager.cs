using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public GameObject Duck2 = null;
    public GameObject Duck3 = null;
    public GameObject Duck4 = null;
    public GameObject Duck5 = null;
    public GameObject Duck6 = null;
    public GameObject Duck7 = null;
    public GameObject DisplayScore;
    private string totalScore;
    public GameObject bulletNumber;
    private int Bullets = 3;
    public GameObject WinBanner;
    public GameObject Round1Counter;
    public GameObject Round2Counter;

    // Start is called before the first frame update
    void Start()
    {
        Duck2.SetActive(false);
        Duck3.SetActive(false);
        Duck4.SetActive(false);
        Duck5.SetActive(false);
        Duck6.SetActive(false);
        Duck7.SetActive(false);
        WinBanner.SetActive(false);
        Round2Counter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        totalScore = DisplayScore.GetComponent<TextMeshProUGUI>().text;
        if (totalScore == "2000")
        {
            Duck2.SetActive(true);
            Duck3.SetActive(true);
            Bullets = 3;
            bulletNumber.GetComponent<TextMeshProUGUI>().text = Bullets.ToString();

        }
        if (totalScore == "4000")
        {
            Duck4.SetActive(true);
            Duck5.SetActive(true);
            Bullets = 3;
            bulletNumber.GetComponent<TextMeshProUGUI>().text = Bullets.ToString();
        }
        if (totalScore == "6000")
        {
            Duck6.SetActive(true);
            Duck7.SetActive(true);
            Bullets = 3;
            bulletNumber.GetComponent<TextMeshProUGUI>().text = Bullets.ToString();
        }
        if(totalScore == "8000")
        { 
            Application.LoadLevel("DuckHuntRound2");
        }
        if(totalScore == "9000")
        { 
            Round1Counter.SetActive(false);
            Round2Counter.SetActive(true);
        }
        if (totalScore == "10000")
        {
            Duck2.SetActive(true);
            Duck3.SetActive(true);
            Bullets = 3;
            bulletNumber.GetComponent<TextMeshProUGUI>().text = Bullets.ToString();
        }
        if (totalScore == "12000")
        {
            Duck4.SetActive(true);
            Duck5.SetActive(true);
            Bullets = 3;
            bulletNumber.GetComponent<TextMeshProUGUI>().text = Bullets.ToString();
        }
        if (totalScore == "14000")
        {
            Duck6.SetActive(true);
            Duck7.SetActive(true);
            Bullets = 3;
            bulletNumber.GetComponent<TextMeshProUGUI>().text = Bullets.ToString();
        }
        if (totalScore == "16000")
        {
            WinBanner.SetActive(true);
        }
    }
}