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
        var nCard = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse)); // 입력받은 숫자들을 해시셋에 저장

        int M = int.Parse(Console.ReadLine()); // 입력받을 쿼리의 개수
        var queries = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // 입력받은 쿼리들을 문자열 배열로 저장

        string result = ProcessQueries(nCard, queries); // 쿼리들을 순회하며, 쿼리가 해시셋에 존재하는지 확인
        Console.Write(result); // 최종 결과를 한 번에 출력
    }

    static string ProcessQueries(HashSet<int> nCard, int[] queries)
    {
        StringBuilder output = new StringBuilder(); // 출력을 위한 StringBuilder

        foreach (var number in queries) // 쿼리들을 순회하며, 쿼리가 해시셋에 존재하는지 확인
        {
            output.Append(nCard.Contains(number) ? "1 " : "0 "); // 해시셋에 존재하는지 확인
        }
        return output.ToString();
    }
}
