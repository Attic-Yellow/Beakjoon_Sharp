/*
* 작 성 일: 2023-12-02
* 문재 번호: 1269
* 문제 제목: 대칭 차집합
* 문제 링크: https://www.acmicpc.net/problem/1269
* 풀이 방법: 
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');
        string[] numA = Console.ReadLine().Split(' ');
        string[] numB = Console.ReadLine().Split(' ');

        int A = int.Parse(numbers[0]); // A의 개수
        int B = int.Parse(numbers[1]); // B의 개수

        HashSet<int> groupA = new HashSet<int>(A);
        HashSet<int> groupB = new HashSet<int>(B);
        
        for(int i = 0; i < A; i++)
        {
            groupA.Add(int.Parse(numA[i]));
        }

        for(int i = 0; i < B; i++)
        {
            int num = int.Parse(numB[i]);
            if (groupA.Contains(num))
            {
                groupA.Remove(num);
            }
            else
            {
                groupB.Add(num);
            }
        }

        int answer = groupA.Count() + groupB.Count();

        Console.WriteLine(answer);
    }
}
