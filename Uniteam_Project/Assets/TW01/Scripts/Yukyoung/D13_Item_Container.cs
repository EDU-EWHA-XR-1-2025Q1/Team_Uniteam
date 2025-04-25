using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D13_Item_Container : MonoBehaviour
{
    public GameObject Target;
    public int cloneCount = 10; //�� �� clone�� ��


    private void Start()
    {
        Instantiate_GameObject();
    }

    void Instantiate_GameObject() //for �ݺ����� �̿��ؼ� clone ����
    {
        for (int i = 0; i < cloneCount; i++)
        {
            //������ Ŭ���� ��ġ ����
            Vector3 randomSphere = Random.insideUnitSphere * 2.5f; //insideUnitSphere: 1 unit �̳����� ������ ��ġ���� Vector3 Ÿ���� ������ �����
            randomSphere.y = 0f; //���̴� 0����
            Vector3 randomPos = randomSphere + transform.position; //�⺻�����δ� ������ ���� world�� ������ �������� �����Ǵµ� item�� ��ġ�� �������� �����ǵ���
            
            //������ Ŭ���� r���� ����       
            float randomAngle = Random.value * 360f;
            Quaternion randomRot = Quaternion.Euler(0, randomAngle, 0);
            GameObject Clone = Instantiate(Target, randomPos, randomRot);

            Clone.SetActive(true);
            Clone.name = "Clone-"+string.Format("{0:D4}",i); //1�϶� 0001�� formating�Ǿ� �̸��� �ٿ���

            Clone.transform.SetParent(transform); 
        }
    }
}
