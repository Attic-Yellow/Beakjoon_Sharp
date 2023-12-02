/*
* 작 성 일: 2023-11-29
* 문재 번호: 27323
* 문제 제목: 직사각형 [다국어]
* 문제 링크: https://www.acmicpc.net/problem/27323
* 풀이: 두 개의 변의 길이를 곱함 
*/
using System;

class Program
{
    // 직사각형의 넓이를 구하는 함수
    static void Rectangle(int height, int width)
    {
        int area = height * width;

        Console.WriteLine($"{area}");
    }

    static void Main(string[] args)
    {
        int height = int.Parse(Console.ReadLine()); // 높이 입력
        int width = int.Parse(Console.ReadLine()); // 너비 입력

        Rectangle(height, width);
    }
}

