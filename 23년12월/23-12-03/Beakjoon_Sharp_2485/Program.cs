﻿/*
* 작 성 일: 2023-12-03
* 문재 번호: 2485
* 문제 제목: 가로수
* 문제 링크: https://www.acmicpc.net/problem/2485
* 풀이 방법: 
*   1. 가로수의 위치를 배열로 입력받습니다.
*   2. 인접한 가로수 사이의 간격을 계산합니다.
*   3. 모든 간격의 최대공약수(GCD)를 유클리드 호제법을 이용해 구합니다.
*   4. 최대공약수를 이용해 필요한 추가 가로수의 수를 계산합니다.
*   5. 계산된 추가 가로수의 수를 출력합니다.
*/
using System;

class Program
{

    // 유클리드 호제법을 이용해 최대공약수를 구하는 함수
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return GCD(b, a % b);
    }

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int gcd = 0;
        int answer = 0;
        List<int> treeList = new List<int>();
        List<int> intervalList = new List<int>();
        
        // 가로수의 위치를 입력받습니다.
        for (int i = 0; i < N; i++)
        {
            treeList.Add(int.Parse(Console.ReadLine()));
        }

        gcd = treeList[1] - treeList[0];

        // 인접한 가로수 사이의 간격을 계산하고 최대공약수를 구합니다.
        for (int i = 1; i < N - 1; i++)
        {
            int interval = treeList[i + 1] - treeList[i];
            gcd = GCD(gcd, interval);
        }

        // 필요한 추가 가로수의 수를 계산합니다.
        for (int i = 0; i < N - 1; i++)
        {
            int interval = treeList[i + 1] - treeList[i];
            answer += interval / gcd - 1;
        }
        Console.WriteLine(answer);
    }
}