/*
* 작 성 일: 2023-12-03
* 문재 번호: 1735
* 문제 제목: 분수 합
* 문제 링크: https://www.acmicpc.net/problem/1735
* 풀이 방법: 
*   1. 두 분수의 분자와 분모를 입력받습니다.
*   2. 두 분모의 최소공배수(LCM)를 구합니다.
*   3. 최소공배수를 기준으로 두 분수의 분자를 조정하여 더합니다.
*   4. 합한 분수의 분자와 분모의 최대공약수(GCD)를 유클리드 호제법으로 구합니다.
*   5. 최대공약수로 분자와 분모를 나누어 기약분수 형태로 결과를 축약합니다.
*   6. 기약분수 형태의 결과를 출력합니다.
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
        int A, B, C, D; // 분수의 분자와 분모
        string[] input = Console.ReadLine().Split();
        A = int.Parse(input[0]);
        B = int.Parse(input[1]);

        input = Console.ReadLine().Split();
        C = int.Parse(input[0]);
        D = int.Parse(input[1]);

        int LCMValue = LCM(B, D); // 두 분모의 최소공배수
        int numerator = A * (LCMValue / B) + C * (LCMValue / D); // 두 분수의 분자를 최소공배수로 맞춘 후 더함
        int GCDValue = GCD(numerator, LCMValue); // 두 분수의 합의 분자와 분모의 최대공약수

        numerator /= GCDValue; // 최대공약수로 분자를 나누어 기약분수 형태로 축약
        LCMValue /= GCDValue; // 최대공약수로 분모를 나누어 기약분수 형태로 축약

        Console.WriteLine(numerator + " " + LCMValue); // 기약분수 형태의 결과 출력
    }
}