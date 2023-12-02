/*
* 작 성 일: 2023-11-30
* 문재 번호: 14215
* 문제 제목: 세 막대
* 문제 링크: https://www.acmicpc.net/problem/14215
* 풀이: 세 막대의 길이를 비교하여 삼각형을 만들 수 있는 최대 둘레를 출력
*/
using System;

class Program
{
    // 세 막대의 길이를 비교하여 삼각형을 만들 수 있는 최대 둘레를 출력하는 함수
    static void Tryangle()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int[] lines = Array.ConvertAll(inputs, int.Parse);
        Array.Sort(lines); // 입력받은 값을 오름차순으로 정렬


        int sum = lines[0] + lines[1]; // 짧은 막대들의 길이의 합을 구함

        if (sum <= lines[2]) // 가장 긴 막대의 길이가 나머지 두 막대의 길이의 합보다 크거나 같은 경우
        {
            lines[2] = sum - 1;
        }

        int answer = lines[2] + sum;
        Console.WriteLine(answer);
    }

    static void Main(string[] args)
    {
        Tryangle();
    }
}
