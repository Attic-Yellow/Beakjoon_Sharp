/*
* 작 성 일: 2023-12-02
* 문재 번호: 11478
* 문제 제목: 서로 다른 부분 문자열의 개수
* 문제 링크: https://www.acmicpc.net/problem/11478
* 풀이 방법: 
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine(); // 문자열

        HashSet<string> subStr = new HashSet<string>(); // 부분 문자열을 저장할 해시테이블

        for(int i = 0; i < str.Length; i++)
        {
            for(int j = 1; j <= str.Length - i; j++)
            {
                subStr.Add(str.Substring(i, j)); // 부분 문자열을 해시테이블에 추가
            }
        }

        Console.WriteLine(subStr.Count);
    }
}