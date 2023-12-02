/*
* 작 성 일: 2023-11-29
* 문재 번호: 2581
* 문제 제목: 소수
* 문제 링크: https://www.acmicpc.net/problem/2581
* 풀이 : 소수를 판변하는 함수로 소수를 판별한 후, 소수이면 primeSum에 더하고, primeMin에는 i를 저장한다.
*/
using System;

class Program
{
    // 소수 판별 함수
    static bool isPrime(int number)
    {
        if (number <= 1) { return false; }   // 1은 소수가 아님
        if (number == 2) { return true; }    // 2는 소수
        if (number % 2 == 0) { return false; }  // 짝수는 소수가 아님
        for (int i = 3; i * i <= number; i += 2) // 3부터 입력받은 수의 제곱근까지 반복
        {
            if (number % i == 0) { return false; } // 나누어 떨어지는 수는 소수가 아님
        }
        return true;
    }

    static void Main(string[] args)
    {
        int smallNum = 0, bigNum = 0;   // 입력받은 수
        int primeSum = 0, primeMin = -1; // 소수들의 합, 소수들 중 최솟값

        smallNum = int.Parse(Console.ReadLine());
        bigNum = int.Parse(Console.ReadLine());

        for (int i = smallNum; i <= bigNum; i++)
        {
            if (isPrime(i))
            {
                primeSum += i;
                if (primeMin == -1)
                {
                    primeMin = i;
                }
            }
        }

        if (primeSum == 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(primeSum);
            Console.WriteLine(primeMin);
        }
    }
}

