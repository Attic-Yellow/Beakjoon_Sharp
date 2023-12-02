/*
* 작 성 일: 2023-12-01
* 문재 번호: 2587
* 문제 제목: 대표값2
* 문제 링크: https://www.acmicpc.net/problem/2587
* 풀이 방법: 5개의 정수를 입력받아 평균값과 중앙값을 계산한 후 출력
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine());
            list.Add(n);
            sum += n;
        }

        list.Sort();

        Console.WriteLine($"{sum / 5}\n{list[2]}");

    }
}

/*블로그 작성 안함 작성 해야함*/