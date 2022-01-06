using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    #region
    //�ƶ��ٶ�
    public float move_speed;
    //
    private float hor;
    private float ver;
    //����
    private float gravity = 16f;
    //�����ٶ�
    public float jump_speed;
    //��Χ��
    public CharacterController controller;
    //���ʵ���ƶ�����
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
        //�ж�����Ƿ��ڵ�����
        if (controller.isGrounded)
        {
            //����ڵ�����
            //���x��z�������ƶ�����
            //
          
            hor = Input.GetAxis("Horizontal");
            //
            ver = Input.GetAxis("Vertical");
            //
            player_move = (transform.forward * ver + transform.right * hor) * move_speed;
            //�����Ծ
         
            if (Input.GetAxis("Jump")==1)
            {
                player_move.y = jump_speed;
            }
           
        }
        //ģ������Ч��
        player_move.y = player_move.y - gravity * Time.deltaTime;
        //������ƶ�
        controller.Move(player_move*Time.deltaTime);
      
    }
}
