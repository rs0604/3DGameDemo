using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private Vector3 velocity;

    [SerializeField] private float moveSpeed = 5.0f;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.E)) {
            velocity.z += 1;
        }
        if (Input.GetKey(KeyCode.S)) {
            velocity.x -= 1;
        }
        if (Input.GetKey(KeyCode.D)) {
            velocity.z -= 1;
        }
        if (Input.GetKey(KeyCode.F)) {
            velocity.x += 1;
        }

        // 速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整する
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;
        
        // いずれかの方向に移動している場合
        if (velocity.magnitude > 0) {
            // プレイヤーの位置(transform.position)の更新
            // 移動方向ベクトル(velocity)を足す
            transform.position += velocity;
        }

    }
}
