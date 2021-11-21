using UnityEngine;
using System.Linq; //LinQ Query �d�߻y�� - ��Ƭd��

/// <summary>
///  �{�ѤG���}�C
/// </summary>
public class Learn2DArray : MonoBehaviour
{
    //�@���}�C
    public int[] numbers = { 1, 7, 9, 10, 50 };
    //�G���}�C
    public int[,] blocks = { { 2, 4 }, { 6, 8 } };

    public string[,] objects = new string[4, 6];

    public int[,] scores = { { 70, 90 }, { 77, 30 }, { 10, 20 } };

    private void Start()
    {
        #region �s��
        //�@���}�C�s��
        numbers[4] = 99;
        print("�@���}�C�Ĥ�����:" + numbers[4]);

        //�G���}�C�s��
        print("�G���}�C�ĤG�C�Ĥ@�� 1, 0: " + blocks[1, 0]);
        blocks[1, 0] = 7;
        print("�G���}�C�ĤG�C�Ĥ@�� 1, 0: " + blocks[1, 0]);

        print("�G���}�C�Ĥ@���ת���:" + scores.GetLength(0));
        print("�G���}�C�Ĥ@���ת���:" + scores.GetLength(1));

        string result = "";

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            for(int j = 0; j < scores.GetLength(1); j++)
            {
                result += scores[i, j] + "l";
            }

            result += "\n";
        }

        print(result);
        #endregion

        #region ��ƻ`��

        //�j�M numbers �@���}�C���j�󵥩� 10 �����
        // var �L������ƫ��A
        //from ���A in �}�C        -�q�}�C�j�M��ƫO�s�� ���A
        //where ���A ����          -�P�_ ���A �O�_�ŦX����
        //select ���A :            -��� �ŦX����  ���A
        var numbverGratgerTen =
            from int n in numbers
            where n >= 10
            select n;

        print("�ŦX >= 10 y ��Ʀ��X�� :" + numbverGratgerTen.Count());

        for (int i = 0; i < numbverGratgerTen.Count(); i++)
        {
            print(">=10����Ƭ�:" + numbverGratgerTen.ToArray()[i]);
        }
        #endregion
    }
}
