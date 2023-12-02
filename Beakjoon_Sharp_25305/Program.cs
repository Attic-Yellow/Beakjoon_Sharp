/*
* 작 성 일: 2023-12-01
* 문재 번호: 25305
* 문제 제목: 커트라인
* 문제 링크: https://www.acmicpc.net/problem/25305
* 풀이 방법: 내림차순으로 정렬하여 특정 순위의 점수를 출력
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // 한 줄에 두 개의 값을 공백으로 분리하여 입력받음
        string[] inputs = Console.ReadLine().Split(' ');
        int numberOfPeople = int.Parse(inputs[0]); // 응시 인원 수
        int cutLine = int.Parse(inputs[1]); // 상을 받을 수 있는 인원 수
        List<int> scores = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // 응시자들의 점수를 저장할 리스트

        scores.Sort(); // 오름차순 정렬
        scores.Reverse(); // 내림차순으로 바꾸기 위한 반전

        // scores.Sort((a, b) => b.CompareTo(a)); // 람다식을 사용하여 내림차순 정렬

        Console.WriteLine(scores[cutLine - 1]);
    }
}

/*블로그 작성 안함 작성 해야함*/