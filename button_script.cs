using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_script : MonoBehaviour
{
    public float currency = 1000;
    public int[,] shopItems = new int[5, 5];
    public Text nutrients_text;
    

    void Start()
    {
        
        nutrients_text.text = "nutrients: " + currency.ToString();

        //ID's
        shopItems[1,1] = 1;
        shopItems[1,2] = 2;
        shopItems[1,3] = 3;
        shopItems[1,4] = 4;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;

        //Quantity
        shopItems[3, 1] = 1;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;


    }
    // Update is called once per frame
    void Update()
    {
        

    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (currency >= shopItems[2, ButtonRef.GetComponent<button_info>().ItemID])
        {
            currency -= shopItems[2, ButtonRef.GetComponent<button_info>().ItemID];
            shopItems[3, ButtonRef.GetComponent<button_info>().ItemID]++;
            nutrients_text.text = "nutrients: " + currency.ToString();
            ButtonRef.GetComponent<button_info>().QuantityText.text = shopItems[3, ButtonRef.GetComponent<button_info>().ItemID].ToString();
        }
    }
}
