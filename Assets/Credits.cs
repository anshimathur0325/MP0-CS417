using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class credits : MonoBehaviour
{
    public Button m_YourFirstButton;
    public GameObject myPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {

        Debug.Log("going back2");
        Destroy(transform.parent.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
