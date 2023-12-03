/*
* 작 성 일: 2023-12-02
* 문재 번호: 14425
* 문제 제목: 문자열 집합
* 문제 링크: https://www.acmicpc.net/problem/14425
* 풀이 방법: Contains을 이용한 풀이
*/
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int count = 0; // 존재하는 문자열의 개수

        var inputNum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); 
        int N = inputNum[0]; // 입력받을 숫자의 개수
        int M = inputNum[1]; // 입력받을 쿼리의 개수

        var nStr = new HashSet<string>(); // 입력받은 문자열들을 저장할 해시셋

        for (int i = 0; i < N; i++)
        {
            nStr.Add(Console.ReadLine()); // 문자열을 해시셋에 저장
        }


        for (int i = 0; i < M; i++)
        {
            if (nStr.Contains(Console.ReadLine())) // 해시셋에 존재하는지 확인
            {
                count++; // 존재하면 카운트 증가
            }
        }

        Console.Write(count);
    }
}
