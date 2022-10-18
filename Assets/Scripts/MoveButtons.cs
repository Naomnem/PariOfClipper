using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtons : MonoBehaviour
{
    //Изменяем Дистанцию, задержку, для того чтобы объект успел дойти до своего места, скорость перемещения, напрваление объекта
    [SerializeField] private float Range;
    [SerializeField] private int Delay;
    [SerializeField] private float speed;
    [SerializeField] private int Direction;

    private float wait = 0; //Дополнительная задержак для FixeUpdate
    private Vector2 targetPlace; //Координаты места назначения
    private Vector2 startPlace; //Начальная позиция

    void Start()
    {
        //Задаём место назначения и стартовую позицию
        targetPlace = new Vector2((transform.position.x + Range) * Direction , transform.position.y);
        startPlace = new Vector2(transform.position.x, transform.position.y);
    }

    
    void FixedUpdate()
    {
        wait += Time.deltaTime;
        if((int)wait >= 1f * Delay && (int)wait < 3f * Delay)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPlace, speed * Time.deltaTime);
        }


    }
}
