using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class quiz : MonoBehaviour
{
    public GameObject ui;
    public GameObject list1;
    public GameObject list2;
    public GameObject list3;
    public GameObject list4;
    public GameObject list5;
    public GameObject list6;
    public GameObject list7;
    public GameObject list8;
    public GameObject list9;
    public GameObject list10;
    
    private int score;
    void Start()
    {
       score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ui.SetActive(!ui.activeSelf);
            list1.SetActive(!list1.activeSelf);
        }

    }
    void UpdateScoreText()
    {
        
    }
    public void Next1()
    {
        list2.SetActive(!list2.activeSelf);
        list1.SetActive(!list1.activeSelf);
     
    }
    public void Next1C()
    {
        list2.SetActive(!list2.activeSelf);
        list1.SetActive(!list1.activeSelf);
        score++;
        UpdateScoreText();
    }


    public void Next2()
    {
        list3.SetActive(!list3.activeSelf);
        list2.SetActive(!list2.activeSelf);

    }
    public void Next2C()
    {
        list3.SetActive(!list3.activeSelf);
        list2.SetActive(!list2.activeSelf);
        score++;
        UpdateScoreText();
    }
    public void Next3()
    {
        list4.SetActive(!list4.activeSelf);
        list3.SetActive(!list3.activeSelf);
        UpdateScoreText();

    }
    public void Next3C()
    {
        list4.SetActive(!list4.activeSelf);
        list3.SetActive(!list3.activeSelf);
        score++;
        UpdateScoreText();
    }


    public void Next4()
    {
        list5.SetActive(!list5.activeSelf);
        list4.SetActive(!list4.activeSelf);

    }
    public void Next4C()
    {
        list5.SetActive(!list5.activeSelf);
        list4.SetActive(!list4.activeSelf);
        score++;
    }
    public void Next5()
    {
        list6.SetActive(!list6.activeSelf);
        list5.SetActive(!list6.activeSelf);

    }
    public void Next5C()
    {
        list6.SetActive(!list6.activeSelf);
        list5.SetActive(!list5.activeSelf);
        score++;
    }
    public void Next6()
    {
        list7.SetActive(!list7.activeSelf);
        list6.SetActive(!list6.activeSelf);

    }
    public void Next6C()
    {
        list7.SetActive(!list7.activeSelf);
        list6.SetActive(!list6.activeSelf);
        score++;
    }
    public void Next7()
    {
        list8.SetActive(!list8.activeSelf);
        list7.SetActive(!list7.activeSelf);

    }
    public void Next7C()
    {
        list8.SetActive(!list8.activeSelf);
        list7.SetActive(!list7.activeSelf);
        score++;
    }
    public void Next8()
    {
        list9.SetActive(!list9.activeSelf);
        list8.SetActive(!list8.activeSelf);

    }
    public void Next8C()
    {
        list9.SetActive(!list9.activeSelf);
        list8.SetActive(!list8.activeSelf);
        score++;
    }
    public void Next9()
    {
        list10.SetActive(!list10.activeSelf);
        list9.SetActive(!list9.activeSelf);

    }
    public void Next9C()
    {
        list10.SetActive(!list10.activeSelf);
        list9.SetActive(!list9.activeSelf);
        score++;
    }
}
