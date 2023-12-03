/*
* 작 성 일: 2023-12-01
* 문재 번호: 1427
* 문제 제목: 소트인사이드
* 문제 링크: https://www.acmicpc.net/problem/1427
* 풀이 방법: 입력받은 숫자 문자열의 각 자릿수를 분리하여 내림차순으로 정렬한 뒤, 이를 연속적으로 출력하는 알고리즘을 구현
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine(); // 문자열 형태로 숫자를 입력받음
        
        List<int> number = input.Select(c => int.Parse(c.ToString())).ToList(); // 각 문자를 정수로 변환하여 리스트에 추가

        number.Sort((a, b) => b.CompareTo(a));

        for(int i = 0; i < number.Count; i++)
        {
            Console.Write($"{number[i]}");
        }
    }
}