using UnityEngine;
using System.Linq; //LinQ Query 查詢語言 - 資料查詢

/// <summary>
///  認識二維陣列
/// </summary>
public class Learn2DArray : MonoBehaviour
{
    //一為陣列
    public int[] numbers = { 1, 7, 9, 10, 50 };
    //二維陣列
    public int[,] blocks = { { 2, 4 }, { 6, 8 } };

    public string[,] objects = new string[4, 6];

    public int[,] scores = { { 70, 90 }, { 77, 30 }, { 10, 20 } };

    private void Start()
    {
        #region 存取
        //一維陣列存取
        numbers[4] = 99;
        print("一維陣列第五比資料:" + numbers[4]);

        //二維陣列存取
        print("二維陣列第二列第一欄 1, 0: " + blocks[1, 0]);
        blocks[1, 0] = 7;
        print("二維陣列第二列第一欄 1, 0: " + blocks[1, 0]);

        print("二維陣列第一維度長度:" + scores.GetLength(0));
        print("二維陣列第一維度長度:" + scores.GetLength(1));

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

        #region 資料蒐集

        //搜尋 numbers 一維陣列內大於等於 10 的資料
        // var 無類型資料型態
        //from 資料A in 陣列        -從陣列搜尋資料保存為 資料A
        //where 資料A 條件          -判斷 資料A 是否符合條件
        //select 資料A :            -選取 符合條件的  資料A
        var numbverGratgerTen =
            from int n in numbers
            where n >= 10
            select n;

        print("符合 >= 10 y 資料有幾筆 :" + numbverGratgerTen.Count());

        for (int i = 0; i < numbverGratgerTen.Count(); i++)
        {
            print(">=10的資料為:" + numbverGratgerTen.ToArray()[i]);
        }
        #endregion
    }
}
