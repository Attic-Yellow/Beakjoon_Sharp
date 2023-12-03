/*
* 작 성 일: 2023-12-03
* 문재 번호: 1934
* 문제 제목: 최소공배수
* 문제 링크: https://www.acmicpc.net/problem/1934
* 풀이 방법: 
*   1. 여러 쌍의 정수를 입력받습니다.
*   2. 각 쌍에 대해 유클리드 호제법을 사용하여 최대공약수(GCD)를 구합니다.
*   3. 두 수의 곱을 최대공약수로 나누어 최소공배수(LCM)를 계산합니다.
*   4. 각 쌍의 최소공배수를 출력합니다.
*/
using System;

class Program
{
    // 최대공약수를 구하는 함수
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return GCD(b, a % b);
    }

    // 최소공배수를 구하는 함수
    static int LCM(int a, int b)
    {
        return a * b / GCD(a, b);
    }

    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine()); // 테스트 케이스 개수 입력

        for (int i = 0; i < testCase; i++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            Console.WriteLine(LCM(a, b));
        }
    }
}