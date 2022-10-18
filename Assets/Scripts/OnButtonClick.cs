using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonClick : MonoBehaviour
{
    //Цвета кнопок, по порядку начальный, для того чтобы позже вернуться на начальное положение, при првильном ответе, при ложном ответе
    public Color startColor , trueButton , falseButton ;
    //Этот объект нужен чтобы менять цвет кнопки
    SpriteRenderer myRenderer;
  
    void Start()
    {
        myRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        this.gameObject.AddComponent<BoxCollider2D>();
    }
    


    void FixedUpdate()
    {
        
            ColorsOfButton();
    }

    private void OnMouseDown()
    {
        //Тест того, что цвета отображаются правильно
        if (myRenderer.color == startColor)
        {
            myRenderer.color = trueButton;
        }
        else if (myRenderer.color == trueButton)
        {
            myRenderer.color = falseButton;
        }
        else
        {
            myRenderer.color = startColor;
        }

    }
    
    //Принимаем цвета кнопок
    private void ColorsOfButton()
    {
        startColor = new Color(255, 255, 255, 64);
        trueButton = new Color(0, 255, 0, 64);
        falseButton = new Color(255, 0, 0, 64);
    }

}
