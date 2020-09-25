using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnlyOneObj : MonoBehaviour
{
   public Button yourButton;
    public GameObject prefeb1 = null;
    public GameObject prefeb2 = null;
    public GameObject prefeb3 = null;

    
	void Start () {
		Button btn = yourButton.GetComponent<Button>();
        MeshRenderer meshr1 = prefeb1.GetComponent<MeshRenderer>();
        MeshRenderer meshr2 = prefeb2.GetComponent<MeshRenderer>();
        MeshRenderer meshr3 = prefeb2.GetComponent<MeshRenderer>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
        
    }

}
