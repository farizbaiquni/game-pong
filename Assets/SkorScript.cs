using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkorScript : MonoBehaviour
{

    public static SkorScript instance;

    public Text textSkorPlayer1;
    public Text textSkorPlayer2;

    public GameObject player1Win;
    public GameObject player2Win;
    public GameObject seri;

    public int skorPlayer1 = 0;
    public int skorPlayer2 = 0;


    // Start is called before the first frame update
    void Awake(){
        try{
            textSkorPlayer1.text = skorPlayer1.ToString();
            textSkorPlayer2.text = skorPlayer2.ToString(); 
        }
        catch (System.Exception){
        }
        

        if(instance == null){
           instance = this;
        }
    }


    // Update is called once per frame
    void Update(){
        
        
    }

    public void TambahSkorPLayer1(){
        skorPlayer1 ++;
        textSkorPlayer1.text = skorPlayer1.ToString();
    }

    public void TambahSkorPLayer2(){
        skorPlayer2 ++;
        textSkorPlayer2.text = skorPlayer2.ToString();
    }

   
}
