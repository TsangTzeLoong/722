using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Exit : MonoBehaviour
{
[SerializeField]
private Button _startBtn;
[SerializeField]
private Button _exitBtn;
[SerializeField]
private GameObject _popWindow;    
[SerializeField]
private Button _cancelBtn;
    void Start()
    {
        _startBtn.onClick.AddListener(Play);
        _exitBtn.onClick.AddListener(ClosePopUp);        
        _cancelBtn.onClick.AddListener(ClosePop);
    }
    private void ClosePopUp(){
        _popWindow.gameObject.SetActive(true);
    }
    private void ClosePop(){
        _popWindow.gameObject.SetActive(false);
    }
    private void Play(){
        Debug.Log("Play");
    }
}
