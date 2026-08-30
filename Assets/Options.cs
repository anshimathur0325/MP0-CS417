using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Options : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button m_YourFirstButton;
    public Slider sli;

    public GameObject myPrefab;
    public Image panel;
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        // color.onClick.AddListener(changeColor);
        sli.value = AudioListener.volume;
        sli.onValueChanged.AddListener(changeSound);
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
        AudioListener.volume = s;
    }
    void Update()
    {
        
    }
}
