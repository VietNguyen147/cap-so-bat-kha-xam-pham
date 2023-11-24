using System;

class Program
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Nhập vào một số nguyên dương có 3 chữ số (n): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 1000 || n > 9999);

        Console.WriteLine($"Các số bất khả xâm phạm nhỏ hơn {n} và không phải số nguyên tố:");
        HienThiSoBatKhaXamPhamVaLoaiBoNguyenTo(n);
    }

    static void HienThiSoBatKhaXamPhamVaLoaiBoNguyenTo(int n)
    {
        for (int i = 1; i < n; i++)
        {
            if (LaSoBatKhaXamPham(i) && !LaSoNguyenTo(i))
            {
                Console.Write($"{i} ");
            }
        }
    }

    static bool LaSoBatKhaXamPham(int num)
    {
        string strNum = num.ToString();
        for (int i = 0; i < strNum.Length; i++)
        {
            int digit = int.Parse(strNum[i].ToString());
            if (digit == 0 || num % digit != 0)
            {
                return false;
            }
        }
        return true;

    }

    static bool LaSoNguyenTo(int num)
    {
        if (num < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}