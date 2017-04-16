using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabManager : MonoBehaviour {

    [SerializeField]
    private Image[] tabImage;
    [SerializeField]
    private Sprite passive;
    public int Index;
    [SerializeField]
    private ItemManager itemManager;
    [SerializeField]
    private ScrollRect contentScrollRect;

    // Use this for initialization
    void Start() {
        SetImage(0);
    }

    // Update is called once per frame
    void Update() {

    }

    public void SetImage(int index) {
        if (tabImage.Length <= index) { return; }
        Index = index;
        foreach (var item in tabImage) {
            item.sprite = passive;
        }
        foreach (var item in itemManager.ContentObj) {
            item.SetActive(false);
        }
        tabImage[Index].sprite = null;
        itemManager.ContentObj[Index].SetActive(true);
        contentScrollRect.content = itemManager.ContentObj[Index].GetComponent<RectTransform>();
    }
}
