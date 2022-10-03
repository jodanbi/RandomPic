using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PicCustom : MonoBehaviour
{
    public enum ResList
    {
        수유리김치찌개,
        명동왕돈까스,
        코리아식당,
        소나무연남돈까스,
        뼈해장국,
        더짬뽕,
        수유리김찌,
        미소국수,
        연남동칼국수,
        최사장네닭곰탕,
        용한식당,
        올바른스시
    }
    public ResList restList;
    public Text resultText;
    public Text errorText;
    public Button button;
    public Button Rebutton;
    int count = 1;


    void ListArray()
    {
        //  errorText.text = restList.ToString();
        restList = (ResList)Random.Range(0, 12);
        resultText.text = restList.ToString();

        count++;
        for (int j = 0; j < count; j++)
        {
            if (j == 1)
            {
        //        YellowColor();
                string finishStatus = "두번 남았습니다..";
                errorText.text = finishStatus;
                
            }

            else if (j == 2)
            {
                string finishStatus = "마지막 기회입니다.";
                errorText.text = finishStatus;
          //      RedColor();
            }
            else if (j == 3) 
            {
                button.interactable = false;
                string finishStatus = "설마.. 재시작?";
                errorText.text = finishStatus;
                
            }
            
        }
    }

    public void SelecterListner ()
    {
        ListArray();
    }
    public void OnRetry()
    {
        // 현재 씬 다시 불러오기
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //레드
    void RedColor()
    {
        ColorBlock colorBlock = button.colors;
        //(r, g, b, a) 기준 빨간색으로 normal Color 지정
        colorBlock.normalColor = new Color(1f, 0f, 0f, 1f);
        button.colors = colorBlock;
    }

    //그린
    void GreenColor()
    {
        ColorBlock colorBlock = button.colors;
        //(r, g, b, a) 기준 빨간색으로 normal Color 지정
        colorBlock.normalColor = new Color(0f, 1f, 0f, 1f);
        button.colors = colorBlock;
    }
    //옐로우
    void YellowColor()
    {
        ColorBlock colorBlock = button.colors;
        //(r, g, b, a) 기준 빨간색으로 normal Color 지정
        colorBlock.normalColor = new Color(1f, 0f, 1f, 1f);
        button.colors = colorBlock;
    }

    void Start()
    {
        string firstStatus = "기회는 3번입니다..";
        errorText.text = firstStatus;
        button.interactable = true;
     ///   GreenColor();
    }
    // Update is called once per frame
    void Update()
    {
      //  YellowColor();
    }
}
