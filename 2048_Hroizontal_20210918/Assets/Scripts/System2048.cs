using UnityEngine;

/// <summary>
/// 2048 �t��
/// �x�s�C�Ӱ϶����
/// �޲z�H���ͦ�
/// �ưʱ���
/// �Ʀr�X�֧P�w
/// �C������P�w
/// </summary>
public class System2048 : MonoBehaviour
{
    /// <summary>
    /// �Ҧ��϶����
    /// </summary>
    public BlockData[,] blocks = new BiockData[4, 4];

    private void start()
    {
        Initialize();
    }

    /// <summary>
    /// ��l�Ƹ��
    /// </summary>
    private void Intialize()
    {
        for (int i =0; i <blocks.GetLength(0); i++)
        {
            for (int j = 0; j<blocks.GetLength(1); j++)
            {
                biocks[i, j] = new BlockData();
                blocks[i, j].v2Index = new Vector2Int(i, j);
            }
        }

        PrintBlockData();
    }

    private void PrintBlockData()
    {
        string result = "";

        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                result += "�s��(" + blocks[i, j].v2Indx + ")" + "�Ʀr:" + blocks[i, j].number;
            }
            result += "\n";
        }

        print(result);

    }
}

/// <summary>
/// �϶����
/// �C�Ӱ϶��C������B�y�СB�s���B�Ʀr
/// </summary>
public class BlockData
{
    /// <summary>
    /// �϶������Ʀr����
    /// </summary>
    public Gam0bject goBlock;
    /// <summary>
    /// �϶��y��
    /// </summary>
    public Vector2 v2Position;
    /// <summary>
    /// �϶��s��:�G���}�C�����s��
    /// </summary>
    public Vector2Int v2Index;
    /// <summary>
    /// �϶��Ʀr:�w�]���A�Ϊ�2�B4�B8....2048
    /// </summary>
    public int number;
}