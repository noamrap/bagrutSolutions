using System;

namespace bagrut
{
    class Program
    {
        //----------שאלה אחת-----------
        //הפעולה מקבלת מערך מספרים
        //הפעולה מחזירה אמת אם המערך ממויין בחיוביים
        static bool PosOrder(int[] arr)
        {
            int[] checkarr = new int[arr.Length];
            int checkIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    checkarr[checkIndex++] = arr[i];
            }

            for (int j = 0; j < checkIndex - 1; j++)
            {
                if (checkarr[j] > checkarr[j + 1])
                    return false;
            }

            return true;
        }
        //--------שאלה 2---------
        //  הפעולה מקבלת מערך הפרשים שחסר בו תא אחד
        //הפעולה מחזירה מי הוא התא החסר
        static int missingNum(int[] arr)
        {
            int missingNum = 0;
            int fixedDiff = Math.Abs(arr[0] - arr[1]);
            int otherDiff = 0;
            int[] diffs = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                diffs[i] = Math.Abs(arr[i] - arr[i + 1]);
            }


            for (int m = 0; m < diffs.Length; m++)
            {
                if (!(diffs[m] == fixedDiff))

                {
                    otherDiff = diffs[m];
                }
            }


            for (int k = 0; k < arr.Length - 1; k++)
            {
                if (Math.Abs(arr[k] - arr[k + 1]) == otherDiff)
                {
                    missingNum = arr[k + 1] - fixedDiff;

                }
            }


            return missingNum;
        }




        static void Main(string[] args)
        {

            int[] arr = { 5, 9, -3, 17, 0, 29, -20, -40, 29, 33 };

            bool isOrdered = PosOrder(arr);
            Console.WriteLine("The array is ordered in non-decreasing positive order: " + isOrdered);

            int[] arr2 = { 6, 8, 12, 14, 16, 18 };
            int missingNumber = missingNum(arr2);
            Console.WriteLine($"The missing number is: {missingNumber}");
        }
    }
}