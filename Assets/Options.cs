using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button m_YourFirstButton;
    public Slider sli, sli2;

    public GameObject myPrefab;
    public Image panel;
    public AudioMixer mixer;
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        // color.onClick.AddListener(changeColor);
        // sli.value = BackgroundMusic;
        // sli2.value = SoundEffects;
        sli.value = 1;
        sli2.value = 1;
        sli.onValueChanged.AddListener(changeSound);
        sli2.onValueChanged.AddListener(changeSound2);
    }
    void TaskOnClick()
    {
        Debug.Log("going back");
        Destroy(myPrefab);
    }
    // Update is called once per frame
    // void changeColor()
    // {
    //     panel.color = Random.ColorHSV();
    // }
    void changeSound(float s)
    {
        mixer.SetFloat("BackgroundMusic", s);
    }
    void changeSound2(float s)
    {
        mixer.SetFloat("SoundEffects", s);
    }
    void Update()
    {
        
    }
}
