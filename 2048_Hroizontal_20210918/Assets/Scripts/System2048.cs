using UnityEngine;

/// <summary>
/// 2048 系統
/// 儲存每個區塊資料
/// 管理隨機生成
/// 滑動控制
/// 數字合併判定
/// 遊戲機制判定
/// </summary>
public class System2048 : MonoBehaviour
{
    /// <summary>
    /// 所有區塊資料
    /// </summary>
    public BlockData[,] blocks = new BiockData[4, 4];

    private void start()
    {
        Initialize();
    }

    /// <summary>
    /// 初始化資料
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
                result += "編號(" + blocks[i, j].v2Indx + ")" + "數字:" + blocks[i, j].number;
            }
            result += "\n";
        }

        print(result);

    }
}

/// <summary>
/// 區塊資料
/// 每個區塊遊戲物件、座標、編號、數字
/// </summary>
public class BlockData
{
    /// <summary>
    /// 區塊內的數字物件
    /// </summary>
    public Gam0bject goBlock;
    /// <summary>
    /// 區塊座標
    /// </summary>
    public Vector2 v2Position;
    /// <summary>
    /// 區塊編號:二維陣列內的編號
    /// </summary>
    public Vector2Int v2Index;
    /// <summary>
    /// 區塊數字:預設維，或者2、4、8....2048
    /// </summary>
    public int number;
}