using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{

    int speed;
    public Rigidbody2D sesuatu;
    public Animator animator;
    public AudioSource hitSound;

    // Start is called before the first frame update
    void Start(){
        animator.SetBool("isMove", true);
        int x = Random.Range(0, 2) * 2 - 1; //dapat bernilai 1 atau -1
        int y = Random.Range(0, 2) * 2 - 1; //dapat bernilai 1 atau -1
        speed = Random.Range(20, 26);
        sesuatu.velocity = new Vector2(x, y) * speed;
    }

    // Update is called once per frame
    void FixedUpdate(){
        if(sesuatu.velocity.x > 0){
            sesuatu.transform.localScale = new Vector3(1, 1, 1);
        } else {
            sesuatu.transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    void OnCollisionEnter2D(Collision2D other){
    	if(other.collider.name == "WallVertical-Kiri"){
            SkorScript.instance.TambahSkorPLayer2();
            StartCoroutine(Jeda());
    	}

        if(other.collider.name == "WallVertical-Kanan"){
            SkorScript.instance.TambahSkorPLayer1();
            StartCoroutine(Jeda());
        }

        if(other.collider.tag == "RaketKanan" || other.collider.tag == "RaketKiri" ){
            hitSound.Play();
        }
    }

    IEnumerator Jeda(){
        animator.SetBool("isMove", false);
        sesuatu.velocity = Vector2.zero;
        sesuatu.GetComponent<Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1);
        int x = Random.Range(0, 2) * 2 - 1; //dapat bernilai 1 atau -1
        int y = Random.Range(0, 2) * 2 - 1; //dapat bernilai 1 atau -1
        sesuatu.velocity = new Vector2(x, y) * speed;
        animator.SetBool("isMove", true);
    }
}
