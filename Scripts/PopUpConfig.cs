using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpConfig : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PopUp;
    [HideInInspector]public bool toshowPopUp; 
    // [HideInInspector]public string AlertTitle = "";
    // [HideInInspector]public string AlertMessage = "";

    public Text Title;
    public Text Message;
    void Start()
    {
        toshowPopUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        PopUp.SetActive(toshowPopUp);
        
        // Title.text = AlertTitle;
        // Message.text = AlertMessage;
    }
}
