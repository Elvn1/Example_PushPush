using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject menuPanel;
    public Button menuBtn;
    public Button contin;
    public Slider volumeControll;
    public AudioSource ad;

    void Start()
    {
        ad = GameObject.Find("BGM").GetComponent<AudioSource>();
        volumeControll = GameObject.Find("VolumeSlider").GetComponent<Slider>();
        menuPanel.gameObject.SetActive(false);
        menuBtn = GameObject.Find("MenuBtn").GetComponent<Button>();
        menuBtn.onClick.AddListener(MenuOn);

    }


    void Update()
    {
        volumeControll.value = ad.volume;
        contin.onClick.AddListener(MenuOff);
    }

    void MenuOn()
    {
        menuPanel.gameObject.SetActive(true);
    }
    void MenuOff()
    {
        menuPanel.gameObject.SetActive(false);
    }
}
