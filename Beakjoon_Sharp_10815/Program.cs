/*
* 작 성 일: 2023-12-01
* 문재 번호: 18870
* 문제 제목: 좌표 압축
* 문제 링크: https://www.acmicpc.net/problem/18870
* 풀이 방법: Contains과 StringBuilder를 이용한 풀이
*/
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // 입력받을 숫자의 개수
        HashSet<int> nCard = new HashSet<int>(); // 입력받은 숫자들을 저장할 해시셋

        string[] numbers = Console.ReadLine().Split(' '); // 입력받은 숫자들을 문자열 배열로 저장
        for (int i = 0; i < N; i++)
        {
            nCard.Add(int.Parse(numbers[i])); // 문자열 배열을 순회하며 숫자로 변환한 뒤, 해시셋에 저장
        }

        int M = int.Parse(Console.ReadLine()); // 입력받을 쿼리의 개수
        StringBuilder output = new StringBuilder(); // 출력을 위한 StringBuilder

        string[] queries = Console.ReadLine().Split(' '); // 입력받은 쿼리들을 문자열 배열로 저장

        // 쿼리들을 순회하며, 쿼리가 해시셋에 존재하는지 확인
        for (int i = 0; i < M; i++)
        {
            int number = int.Parse(queries[i]); // 문자열을 숫자로 변환

            if (nCard.Contains(number)) // 해시셋에 존재하는지 확인
            {
                output.Append("1 ");
            }
            else
            {
                output.Append("0 ");
            }
        }

        Console.Write(output.ToString()); // 최종 결과를 한 번에 출력
    }
}
