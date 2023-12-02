/*
*작 성 일: 2023-11-29
* 문재 번호: 11653
* 문제 제목: 소인수분해
* 문제 링크: https://www.acmicpc.net/problem/11653
*풀이 : 입력받은 수를 2부터 입력받은 수의 제곱근까지 반복하여 나누어 떨어지는 수를 소수로 추가한다.
*/

using System;

class Program
{
    // 소인수분해 함수
    static void Factorize(int n)
    {
        for (int i = 2; i * i <= n; i++) // 2부터 입력받은 수의 제곱근까지 반복
        {
            while (n % i == 0)  // 나누어 떨어지는 수를 소수로 추가
            {
                Console.WriteLine(i);
                n /= i; 
            }
        }
        if (n > 1)
        {
            Console.WriteLine(n);
        }
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Factorize(number);
    }
}