/*
* 작 성 일: 2023-11-30
* 문재 번호: 3009
* 문제 제목: 네 번째 점 [다국어]
* 문제 링크: https://www.acmicpc.net/problem/3009
* 풀이: 세 점의 좌표를 입력받아 나머지 한 점의 좌표를 구함
*/
using System;

class Program
{
    // 네번째 점의 좌표를 구하는 함수
    static void FourthPoint(int[] x, int[] y)
    {
        int fourthX, fourthY;

        fourthX = (x[0] == x[1]) ? x[2] : (x[0] == x[2] ? x[1] : x[0]); // 삼항 연산자를 이용하여 네번째 점의 x좌표를 구함
        fourthY = (y[0] == y[1]) ? y[2] : (y[0] == y[2] ? y[1] : y[0]); // 삼항 연산자를 이용하여 네번째 점의 y좌표를 구함

        Console.WriteLine($"{fourthX} {fourthY}");
    }

    static void Main(string[] args)
    {
        int[] x = new int[3];   // x좌표를 저장할 배열
        int[] y = new int[3];   // y좌표를 저장할 배열

        for(int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split(' '); // 입력받은 값을 공백을 기준으로 나누어 저장

            x[i] = int.Parse(input[0]);
            y[i] = int.Parse(input[1]);
        }

        FourthPoint(x, y);
    }
}
