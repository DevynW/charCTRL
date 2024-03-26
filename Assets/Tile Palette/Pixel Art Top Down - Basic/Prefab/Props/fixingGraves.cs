using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixingGraves : MonoBehaviour
{
    [SerializeField] GameObject grave1;
    SpriteRenderer sr1;
    [SerializeField] GameObject grave2;
    SpriteRenderer sr2;
    [SerializeField] GameObject grave3;
    SpriteRenderer sr3;
    [SerializeField] GameObject grave4;
    SpriteRenderer sr4;
    [SerializeField] GameObject grave5;
    SpriteRenderer sr5;
    [SerializeField] GameObject grave6;
    SpriteRenderer sr6;
    [SerializeField] GameObject grave7;
    SpriteRenderer sr7;
    // Start is called before the first frame update
    void Start()
    {
        sr1 = grave1.GetComponent<SpriteRenderer>();
        sr2 = grave2.GetComponent<SpriteRenderer>();
        sr3 = grave3.GetComponent<SpriteRenderer>();
        sr4 = grave4.GetComponent<SpriteRenderer>();
        sr5 = grave5.GetComponent<SpriteRenderer>();
        sr6 = grave6.GetComponent<SpriteRenderer>();
        sr7 = grave7.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -.211f)
        {
            sr1.sortingLayerName = "back";
            sr2.sortingLayerName = "back";
            sr3.sortingLayerName = "back";
            sr4.sortingLayerName = "back";
            sr5.sortingLayerName = "back";
            sr6.sortingLayerName = "back";
            sr7.sortingLayerName = "back";
        }
        else
        {
            sr1.sortingLayerName = "fore";
            sr2.sortingLayerName = "fore";
            sr3.sortingLayerName = "fore";
            sr4.sortingLayerName = "fore";
            sr5.sortingLayerName = "fore";
            sr6.sortingLayerName = "fore";
            sr7.sortingLayerName = "fore";
        }
    }
}
