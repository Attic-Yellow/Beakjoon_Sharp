/*
* 작 성 일: 2023-11-30
* 문재 번호: 9063
* 문제 제목: 대지
* 문제 링크: https://www.acmicpc.net/problem/9063
* 풀이: 최대 x좌표, 최대 y좌표, 최소 x좌표, 최소 y좌표를 구하여 직사각형의 넓이를 구함
*/
using System;

class Program
{
    // 주어진 테스트 케이스 개수만큼 좌표를 입력받아 최소 직사각형 넓이를 계산하는 함수
    static void MaxMin(int testCase)
    {
        int maxX = Int32.MinValue, maxY = Int32.MinValue;
        int minX = Int32.MaxValue, minY = Int32.MaxValue;

        for (int i = 0; i < testCase; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            maxX = Math.Max(maxX, x);
            maxY = Math.Max(maxY, y);
            minX = Math.Min(minX, x);
            minY = Math.Min(minY, y);
        }

        int area = (maxX - minX) * (maxY - minY);

        Console.WriteLine($"{area}");
    }

    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine()); // 테스트 케이스의 개수를 입력받음

        MaxMin(testCase);
    }
}
