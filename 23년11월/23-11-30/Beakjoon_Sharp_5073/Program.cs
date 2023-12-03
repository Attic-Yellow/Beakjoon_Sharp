/*
* 작 성 일: 2023-11-30
* 문재 번호: 5073
* 문제 제목: 삼각형과 세 변
* 문제 링크: https://www.acmicpc.net/problem/5073
* 풀이: 세 변의 길이를 비교하여 삼각형의 종류를 출력
*/
using System;

class Program
{
    // 세 변의 길이를 비교하여 삼각형의 종류를 출력하는 함수
    static void Tryangle()
    {
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int line1 = int.Parse(inputs[0]);
            int line2 = int.Parse(inputs[1]);
            int line3 = int.Parse(inputs[2]);

            // 종료 조건
            if (line1 == 0 && line2 == 0 && line3 == 0)
            {
                break;
            }

            // 삼각형의 성립 조건 검사
            if (line1 + line2 <= line3 || line2 + line3 <= line1 || line1 + line3 <= line2)
            {
                Console.WriteLine("Invalid");
            }
            else if (line1 == line2 && line2 == line3) // 모든 변의 길이가 같은 경우
            {
                Console.WriteLine("Equilateral");
            }
            else if (line1 == line2 || line2 == line3 || line1 == line3) // 두 변의 길이만 같은 경우
            {
                Console.WriteLine("Isosceles");
            }
            else // 모든 변의 길이가 다른 경우
            {
                Console.WriteLine("Scalene");
            }
        }
    }

    static void Main(string[] args)
    {
        Tryangle();
    }
}