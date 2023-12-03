/*
* 작 성 일: 2023-12-03
* 문재 번호: 13241
* 문제 제목: 최소공배수 [다국어]
* 문제 링크: https://www.acmicpc.net/problem/13241
* 풀이 방법: 
*   1. 두 정수 a와 b를 입력받습니다.
*   2. 유클리드 호제법을 사용하여 a와 b의 최대공약수(GCD)를 구합니다.
*   3. 최소공배수(LCM)는 a와 b를 곱한 값에 최대공약수(GCD)를 나눈 값으로 계산합니다.
*   4. 계산된 최소공배수(LCM)를 출력합니다.
*/
using System;

class Program
{
    // 최대공약수를 구하는 함수
    static long GCD(long a, long b)
    {
        if (b == 0)
            return a;
        else
            return GCD(b, a % b);
    }

    // 최소공배수를 구하는 함수
    static long LCM(long a, long b)
    {
        return a * b / GCD(a, b);
    }

    static void Main(string[] args)
    {
        long A, B; // 입력받을 두 정수
        string[] input = Console.ReadLine().Split();
        A = long.Parse(input[0]);
        B = long.Parse(input[1]);

        Console.WriteLine(LCM(A, B)); // 최소공배수 출력
    }
}