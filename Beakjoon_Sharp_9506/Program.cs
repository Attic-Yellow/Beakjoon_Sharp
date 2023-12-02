/*
* 작 성 일: 2023-11-29
* 문재 번호: 9506
* 문제 제목: 약수들의 합
* 문제 링크: https://www.acmicpc.net/problem/9506
* 풀이: 입력받은 수의 약수를 구한 후, 약수들의 합이 입력받은 수와 같은지 비교한다.
*/
using System;

class Program
{
    // 약수 구하는 함수
    static void Divisor(int number)
    {
        List<int> divisorList = new List<int>(); // 약수들을 저장할 리스트
        int sum = 0;    // 약수들의 합

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) // 나누어 떨어지는 수는 약수
            {
               divisorList.Add(i);
               sum += i;
            }
        }

        if (sum == number)   // 약수들의 합이 입력받은 수와 같은지 비교
        {
            Console.Write($"{number} = ");
            for (int i = 0; i < divisorList.Count; i++)
            {
                Console.Write($"{divisorList[i]}");
                if (i < divisorList.Count - 1)
                {
                    Console.Write(" + ");
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.Write($"{number} ");
            Console.WriteLine("is NOT perfect.");
        }
    }

    static void Main(string[] args)
    {
        while(true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == -1)
            {
                break;
            }
            Divisor(number);
        }
    }
}
