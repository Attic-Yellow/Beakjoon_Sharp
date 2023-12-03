/*
* 작 성 일: 2023-12-02
* 문재 번호: 7785
* 문제 제목: 회사에 있는 사람
* 문제 링크: https://www.acmicpc.net/problem/7785
* 풀이 방법: 
*/
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // 명단에 적힌 사람의 수

        Dictionary<string, string> member = new Dictionary<string, string>(); // 명단을 저장할 해시테이블

        for(int i = 0; i < N; i++)
        {
            string[] str = Console.ReadLine().Split(' ');

            if (str[1] == "enter") // enter이면 추가, leave이면 삭제
            {
                member[str[0]] = str[1];
            }
            else
            {
                member.Remove(str[0]);
            }
        }

        List<string> result = new List<string>();

        foreach (string str in member.Keys)
        {
            result.Add(str);
        }

        result.Sort();
        result.Reverse();
        Console.WriteLine(string.Join("\n", result));

    }
}