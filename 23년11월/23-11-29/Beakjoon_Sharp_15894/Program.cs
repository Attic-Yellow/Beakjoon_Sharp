/*
* 작 성 일: 2023-11-30
* 문재 번호: 15894
* 문제 제목: 수학은 체육과목 입니다
* 문제 링크: https://www.acmicpc.net/problem/15894
* 풀이: 블록의 개수를 입력받아 블록의 개수 * 4를 출력함
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        long block = int.Parse(Console.ReadLine()); // 블록의 개수를 입력받음
        long result = block * 4;
        Console.WriteLine(result);
    }
}
