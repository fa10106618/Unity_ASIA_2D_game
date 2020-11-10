
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public GameObject final;

    public Text textCount;

    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
       
    {
        if(collision.name=="傳送門")
        {
            final.SetActive(true);
        }


        //print("碰到傳送門惹");
        if (collision.tag == "鑽石")
        {
            Destroy(collision.gameObject);

            count++;

            textCount.text = "鑽石數量:" + count;
        }

    }

}
