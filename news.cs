using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class news : MonoBehaviour
{
    public GameObject ui;
    public GameObject list1;
    public GameObject list2;
    public GameObject list3;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ui.SetActive(!ui.activeSelf);
            rb.SetActive(!rb.activeSelf);

           
                Time.timeScale = 0f;
            
           
               
            
        }

    }

    public void Next()
    {
        list2.SetActive(!list2.activeSelf);
        list1.SetActive(!list1.activeSelf);
        button1.SetActive(!button1.activeSelf);
        button2.SetActive(!button2.activeSelf);
    }
    public void Next2()
    {
        list3.SetActive(!list3.activeSelf);
        list2.SetActive(!list2.activeSelf);
        button2.SetActive(!button2.activeSelf);
        button3.SetActive(!button3.activeSelf);
    }

    public void Close()
    {
        ui.SetActive(!ui.activeSelf);
        Time.timeScale = 1f;
    }
}
