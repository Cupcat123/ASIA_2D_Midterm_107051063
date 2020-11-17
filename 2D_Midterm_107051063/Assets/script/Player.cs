using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public GameObject final;

    public TextAlignment textCount;

    public Text Tnumber;

    public int number;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            final.SetActive(true);
            print("get ur ass back here");
        }
        if (collision.tag == "珠寶塊")
        {
            Destroy(collision.gameObject);

            number++;
            Tnumber.text = ("珠寶數量:" + number);
         }

    }

    


}
