/*
* 작 성 일: 2023-11-30
* 문재 번호: 19532
* 문제 제목: 수학은 비대면강의입니다
* 문제 링크: https://www.acmicpc.net/problem/19532
* 풀이 방법: 두 선형 연립방정식의 해를 구하는 알고리즘을 구현
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d, e, f;

        // 사용자로부터 입력 받기
        string[] inputs = Console.ReadLine().Split(' ');
        a = int.Parse(inputs[0]);
        b = int.Parse(inputs[1]);
        c = int.Parse(inputs[2]);
        d = int.Parse(inputs[3]);
        e = int.Parse(inputs[4]);
        f = int.Parse(inputs[5]);

        // 연립방정식의 해 계산
        int x = (c * e - b * f) / (a * e - b * d);
        int y = (c * d - a * f) / (b * d - a * e);

        // 결과 출력
        Console.WriteLine($"{x} {y}");
    }
}