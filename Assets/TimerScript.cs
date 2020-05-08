using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public GameObject WinPlayer1;
    public GameObject WinPlayer2;
    public GameObject Seri;

    public int counter = 2;

    public Text timerText;

    // Start is called before the first frame update
    void Start(){
        timerText.text = counter.ToString();
        StartCoroutine(hitungMundur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator hitungMundur(){
        while(counter > 0){
            yield return new WaitForSeconds(1);
            counter -= 1;
            timerText.text = counter.ToString();

        }   
        
        if(SkorScript.instance.skorPlayer1 > SkorScript.instance.skorPlayer2){
            WinPlayer1.SetActive(true);
        } else if(SkorScript.instance.skorPlayer2 > SkorScript.instance.skorPlayer1){
            WinPlayer2.SetActive(true);
        } else {
            Seri.SetActive(true);;
        
    }
   
    }
}
