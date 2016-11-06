using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour
{

    public RaycastHit hit;

    public GameObject player;
    public float speed;
    public GameObject score;
    public GameObject scoreText;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel("Level2");
        }

        
            this.transform.LookAt(player.transform.position);
            Vector3 newRotation = this.transform.rotation.eulerAngles;
            newRotation.y += 90.0f;
            this.transform.rotation = Quaternion.Euler(newRotation);
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        

    }
    

}