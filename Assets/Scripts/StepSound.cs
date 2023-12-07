using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSound : MonoBehaviour {
//ссылочная переменная для аудио-файла
    public AudioClip footsteps;

//публичная функция, получим доступ к ней из аниматора
    public void FootStepsAudio() {
//воспроизвести заданный звук на позиции крысы
        AudioSource.PlayClipAtPoint(footsteps, transform.position);
    }

//запустится если было касание другого Collider2D
    void OnCollisionEnter2D(Collision2D coll) {
//проверка тэга на тэг "Ground"
        if (coll.gameObject.tag == "Ground") {
//воспроизвести заданный звук на позиции крысы
            AudioSource.PlayClipAtPoint(footsteps, transform.position);
        }
    }

}