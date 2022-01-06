using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    #region
    //移动速度
    public float move_speed;
    //
    private float hor;
    private float ver;
    //重力
    private float gravity = 16f;
    //起跳速度
    public float jump_speed;
    //包围盒
    public CharacterController controller;
    //玩家实际移动方向
    Vector3 player_move;
    #endregion
    float timer = 0;
    public float maxTime;
    public GameObject barrage;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        move_speed = 5;
        jump_speed = 5;
        maxTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //判断玩家是否在地面上
        if (controller.isGrounded)
        {
            //玩家在地面上
            //获得x和z方向上移动数据
            //
          
            hor = Input.GetAxis("Horizontal");
            //
            ver = Input.GetAxis("Vertical");
            //
            player_move = (transform.forward * ver + transform.right * hor) * move_speed;
            //玩家跳跃
         
            if (Input.GetAxis("Jump")==1)
            {
                player_move.y = jump_speed;
            }
           
        }
        //模拟重力效果
        player_move.y = player_move.y - gravity * Time.deltaTime;
        //具体的移动
        controller.Move(player_move*Time.deltaTime);
      
    }
}
