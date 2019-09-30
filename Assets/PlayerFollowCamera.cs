using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour {
    // 注視対象プレイヤー
    [SerializeField] private Transform player;
    // 注視対象プレイヤーとの距離
    [SerializeField] private float distance = 4.0f;
    // カメラの垂直回転
    [SerializeField] private Quaternion vRotation;
    // カメラの水平回転
    [SerializeField] public Quaternion hRotation;
    // 回転速度
    [SerializeField] private float turnSpeed = 10.0f;
    
    // Start is called before the first frame update
    void Start() {
        // 回転の初期化
        vRotation = Quaternion.Euler(30, 0, 0);
        hRotation = Quaternion.identity;
        
        // 位置の初期化
        // player位置から距離distanceだけ手前に引いた位置を設定
        transform.position = player.position - transform.rotation
                             * Vector3.forward * distance;
    }

    // Update is called once per frame
    void Update() { }

    void LateUpdate() {
        // 水平回転の更新
        
        // カメラの位置(transform.position)の更新
        // player位置から距離distanceだけ手前に引いた位置を設定
        transform.position = player.position - transform.rotation 
                             * Vector3.forward * distance;
    }
}
