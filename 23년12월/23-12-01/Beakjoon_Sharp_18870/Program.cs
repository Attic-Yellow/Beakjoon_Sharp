/*
* 작 성 일: 2023-12-01
* 문재 번호: 18870
* 문제 제목: 좌표 압축
* 문제 링크: https://www.acmicpc.net/problem/18870
* 풀이 방법: 좌표들을 오름차순으로 정렬하고 중복을 제거한 후, 각 원본 좌표가 정렬된 벡터에서 어느 위치에 있는지를 찾아 그 인덱스를 출력함으로써 좌표를 압축하는 방식으로 작동
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine()); // 입력받을 숫자의 개수
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // 입력받은 숫자들을 리스트에 저장
        List<int> sortedNumbers = numbers.Distinct().ToList(); // 중복을 제거한 뒤, 리스트에 저장

        sortedNumbers.Sort(); // 오름차순 정렬

        Dictionary<int, int> numberIndexes = new Dictionary<int, int>(); // 숫자의 인덱스를 저장할 딕셔너리

        for (int i = 0; i < sortedNumbers.Count; i++) 
        {
            numberIndexes[sortedNumbers[i]] = i;
        }

        StringBuilder output = new StringBuilder(); // 출력을 위한 StringBuilder

        for (int i = 0; i < count; i++)
        {
            output.Append($"{numberIndexes[numbers[i]]} ");
        }

        Console.WriteLine(output.ToString()); // 최종 결과를 한 번에 출력
    }
}