# C#을 이용한 프로그래밍 입문

## Section 1

### 코딩 표준, 가독성, 유지보수성을 지키면서 프로그래밍을 배웁니다.
### 노트 정리는 필수이기 때문에 저는 Markdown 문서로 정리하도록 하겠습니다.


### 6강. C# 이 좋은 이유
- C#은 입문자에게 적합한 최고의 주류 언어이다
- 깔끔 및 간결
- 사용자가 실수를 하기 어려우며
- 뛰어난 개발 환경을 갖고 있음  
- 공식 문서가 잘 되어 있음
- C#을 사용할 수 있는 다양한 프레임워크가 존재한다.
  - .NET 프레임 워크 vs .NET Core
  - 이 과정에선 .NET Core를 사용
  - 현업에서도 .NET Core로 많이 변환되는 중
  - .NET Core는 윈도우, 리눅스, 맥 등 모든 운영체제에서 실행 가능하다
- 개체지향언어이다.

### 7강. C#은 어디에 쓰이나요?

- 윈도우 애플리케이션
- 웹 애플리케이션
  - Asp.net MVC
  - .NET Core
- 모바일 애플리케이션
  - Xamarin
- 모바일, PC 게임
  - Unity(원래 지원 언어는 자바스크립트 C#을 비롯한 세 개 였는데 현재는 C# 단독 지원)
- 마이크로소프트 Azure 의 머신러닝 라이브러리

### 8강 과정 소개

- 프로그램 언어의 기본
  - 다른 프로그래밍 언어에도 동일하게 적용되는 내용
  - 기계와 가까운 프로그래밍
  - 로직을 코드로 표현하는 방법과 상태를 저장하는 방법을 배움
- C#의 고유 기능
  - C# 및 최신 프로그래밍 언어에서 찾을 수 있는 기능
    - LINQ
    - Class
    - Partial Class
    - Property
    - Extention method
    - 예외처리

### 9강. OOP를 무시하고 C#을 사용하기

- 모든 곳에서 Static을 사용해서 과정이 진행 됌
- 이 과정에선 OOP를 다루지 않음

- 이미 존재하는 라이브러리를 사용할 때는 이런 코드를 보게 될 것
  - Console.WriteLine();
  - Random rand = new Random();
- 위 코드 또한 OOP 방식이지만, 이 코스에서는 무시합시다.
- 그냥 이렇게 읽자
	- Console.WriteLine(); -> WriteLineToConsole()
	- Random rand = new Random(); -> Random 라이브러리를 사용하자!


### 10강. 슬라이드 아이콘 중요정도

- 두뇌 아이콘 :
	- 어디서든 사용된
	- 매우 중요
	- 꼭 이해할 것
- 책
	- 일부에서 사용됨
	- 그냥 있다는 것만 알고
	- 실제로 필요할 때는 찾아쓸 것
- 폐기물
  - 대부분 사용 안 됨