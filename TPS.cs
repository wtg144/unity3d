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
        //ŷ����:�����������:������(z)����ת��(y)���¶���(x)
        //��Ԫ��:Quaternion quaternion���Ǽ���������ת��һ�ַ�ʽ
       // Vector3 dir = Vector3.up * 90;
      //  Quaternion quaternion = Quaternion.Euler(dir);
      // Vector3 _dir = quaternion * Vector3.left;
        // ����ȷ����ת���Ҫ��ת�ĽǶ�
        //��ת�ǳ���ת��õ�һ��V3��ֵ
        //Ȼ�����V3��ֵ��ͨ��Quaternion.Euler��ŷ����תΪ��Ԫ��quaternion
        //֮��ֻ��Ҫ����Ҫ��ת���������������Ԫ��quatenron�����ܵõ�����Ҫ��ת����������ת����תָ���Ƕ�֮���������
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
