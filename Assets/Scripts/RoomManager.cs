using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RoomManager : MonoBehaviour, IPointerClickHandler
{

    private void Unknown(){
        Debug.Log("unknow"); 
    }

    public void OnPointerClick(PointerEventData eventData){
        switch (eventData.rawPointerPress.tag)
            {
                case "Unknown": 
                    Unknown();  
                    break;
                case "Enemy": 
                    Debug.Log("1");  
                    break;
                case "EliteEnemy":
                    Debug.Log("2");  
                    break;
                case "Rest":
                    Debug.Log("3");  
                    break;
                case "Boss":
                    Debug.Log("4");  
                    break;
            }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
