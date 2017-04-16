using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    [SerializeField]
    private Text header;
    [SerializeField]
    private Text title;
    [SerializeField]
    private Text duration;

    public void SetInfo(string header, string title, string duration) {
        this.header.text = header;
        this.title.text = title;
        this.duration.text = duration;
    }
}
