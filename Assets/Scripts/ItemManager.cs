using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    public GameObject[] ContentObj;
    [SerializeField]
    private GameObject itemPrefab;
    [SerializeField]
    private Scrollbar verticalScrollBar;
    [SerializeField]
    private GameObject maskObj;
    [SerializeField]
    private TabManager tabManager;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    /// <summary>
    /// コンテンツ追加
    /// </summary>
    private void CreateItem() {
        var clone = Instantiate(itemPrefab, transform.localPosition, Quaternion.identity);
        clone.transform.parent = ContentObj[tabManager.Index].transform;
        clone.transform.localScale = Vector3.one;
        verticalScrollBar.value = 1;
    }

    public void CreateItemUI() {
        maskObj.SetActive(false);
        CreateItem();
    }
    public void OpenMask() {
        maskObj.SetActive(true);
    }

    public void ScrollViewUI(string dir) {
        if (dir == "Up") {
            verticalScrollBar.value = 1;
        } else {
            verticalScrollBar.value = 0;
        }
    }
}
