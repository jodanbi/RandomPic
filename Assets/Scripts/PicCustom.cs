using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PicCustom : MonoBehaviour
{
    public enum ResList
    {
        ��������ġ�,
        ���յ��,
        �ڸ��ƽĴ�,
        �ҳ����������,
        �����屹,
        ��«��,
        ����������,
        �̼ұ���,
        ������Į����,
        �ֻ���״߰���,
        ���ѽĴ�,
        �ùٸ�����
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
                string finishStatus = "�ι� ���ҽ��ϴ�..";
                errorText.text = finishStatus;
                
            }

            else if (j == 2)
            {
                string finishStatus = "������ ��ȸ�Դϴ�.";
                errorText.text = finishStatus;
          //      RedColor();
            }
            else if (j == 3) 
            {
                button.interactable = false;
                string finishStatus = "����.. �����?";
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
        // ���� �� �ٽ� �ҷ�����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //����
    void RedColor()
    {
        ColorBlock colorBlock = button.colors;
        //(r, g, b, a) ���� ���������� normal Color ����
        colorBlock.normalColor = new Color(1f, 0f, 0f, 1f);
        button.colors = colorBlock;
    }

    //�׸�
    void GreenColor()
    {
        ColorBlock colorBlock = button.colors;
        //(r, g, b, a) ���� ���������� normal Color ����
        colorBlock.normalColor = new Color(0f, 1f, 0f, 1f);
        button.colors = colorBlock;
    }
    //���ο�
    void YellowColor()
    {
        ColorBlock colorBlock = button.colors;
        //(r, g, b, a) ���� ���������� normal Color ����
        colorBlock.normalColor = new Color(1f, 0f, 1f, 1f);
        button.colors = colorBlock;
    }

    void Start()
    {
        string firstStatus = "��ȸ�� 3���Դϴ�..";
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
