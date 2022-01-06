using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPS : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
        //欧拉角:由三部分组成:旋近角(z)，自转角(y)，章动角(x)
        //四元数:Quaternion quaternion，是计算机理解旋转的一种方式
       // Vector3 dir = Vector3.up * 90;
      //  Quaternion quaternion = Quaternion.Euler(dir);
      // Vector3 _dir = quaternion * Vector3.left;
        // 首先确定旋转轴和要旋转的角度
        //用转角乘上转轴得到一个V3的值
        //然后将这个V3的值，通过Quaternion.Euler从欧拉角转为四元数quaternion
        //之后只需要让需要旋转的向量乘以这个四元数quatenron，就能得到，需要旋转的向量沿着转轴旋转指定角度之后的新向量
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    player.Rotate(Vector3.up, 5) ;
        //}

        if (Input.GetKey(KeyCode.A))
        {
            player.Rotate(Vector3.up, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.Rotate(Vector3.up, 1);
        }
        transform.position = player.position +player.rotation* offset;
        transform.LookAt(player.position+Vector3.up*2f);
    }
}
