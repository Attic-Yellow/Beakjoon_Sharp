/*
* 작 성 일: 2023-11-30
* 문재 번호: 10101
* 문제 제목: 삼각형 외우기
* 문제 링크: https://www.acmicpc.net/problem/10101
* 풀이: 삼각형의 각도를 입력받아 삼각형의 종류를 출력하는 함수
*/
using System;
class Program
{
    // 삼각형의 각도를 입력받아 삼각형의 종류를 출력하는 함수
    static void Tryangle()
    {
        int angle1 = int.Parse(Console.ReadLine());
        int angle2 = int.Parse(Console.ReadLine());
        int angle3 = int.Parse(Console.ReadLine());

        int angles = angle1 + angle2 + angle3;

        if (angles == 180)
        {
            if (angle1 == 60 && angle2 == 60 && angle3 == 60)   // 삼각형의 각도가 60도인 경우
            {
                Console.WriteLine("Equilateral");
            }
            else if (angle1 == angle2 || angle1 == angle3 || angle2 == angle3)  // 두 각이 같은 경우
            {
                Console.WriteLine("Isosceles");
            }
            else // 같은 각이 없는 경우
            {
                Console.WriteLine("Scalene");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    static void Main(string[] args)
    {
        Tryangle();
    }
}